using Microsoft.AspNetCore.Mvc;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;
using System.Collections.Generic;

namespace MinVoiCe.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public IActionResult Index(int id = 0)
        {
            if (ClientData.IsLoaded == false)
            {
                ClientData.LoadClients();
            };

            //refactor to include other items and pull them from viewbag
            List<Client> Clients = ClientData.GetAll();
            ViewBag.Projects = ProjectData.GetAll();
            ViewBag.SelectProjects = ProjectData.SelectProjects();
            
            if (id == 0)
            {
                ViewBag.Worktimes = WorktimeData.GetAll();
            }

            else
            {
                ViewBag.Worktimes = WorktimeData.GetbyProjectID(id);
            }

            return View(Clients);
        }

        //Dashboard Change
        public IActionResult Dashboard(int ProjectId)
        {
            return Redirect("/Index?=" + ProjectId);
        }

        //Home/AddTime
        public IActionResult AddTime()
        {
            AddTimeViewModel addTimeViewModel = new AddTimeViewModel();
            
            return View(addTimeViewModel);
        }

        [HttpPost]
        public IActionResult Worktime(AddTimeViewModel addTimeViewModel)
        {

            if (ModelState.IsValid)
            {
                Worktime newWorktime = new Worktime
                {
                    Hours = addTimeViewModel.Hours,
                    Date = addTimeViewModel.Date,
                    Description = addTimeViewModel.Description
                };

                newWorktime.Project = ProjectData.GetbyID(addTimeViewModel.ProjectId);
                WorktimeData.Add(newWorktime);

                return Redirect("/");
            }

            return View("Addtime", addTimeViewModel);
        }

        public IActionResult Invoice()
        {
            InvoiceViewModel invoiceViewModel = new InvoiceViewModel();

            if (string.IsNullOrEmpty(invoiceViewModel.ProjectId.ToString()))
            {
                return Redirect("/");
            }

            return View(invoiceViewModel);
        }

        [HttpPost]
        public IActionResult ConfirmInvoice(InvoiceViewModel invoiceViewModel)
        {

            if (ModelState.IsValid)
            {
                List<Worktime> ProjectWorktimes = WorktimeData.GetbyProjectID(invoiceViewModel.ProjectId);

                //foreach (Worktime aWorktime in WorktimeData.GetAll())
                //{
                //    if (aWorktime.Project.ProjectId == invoiceViewModel.ProjectId)
                //    {
                //        ProjectWorktimes.Add(aWorktime);
                //    }
                //}

                if (ProjectWorktimes.Count == 0)
                {
                    return Redirect("/");
                }

                Invoice newInvoice = new Invoice();

                newInvoice.Worktimes = ProjectWorktimes;
                newInvoice.Project = ProjectData.GetbyID(invoiceViewModel.ProjectId);
                newInvoice.Total();

                return View(newInvoice);

            }

            return View("Invoice", invoiceViewModel);
        }

    }

}


        