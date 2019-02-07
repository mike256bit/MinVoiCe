using Microsoft.AspNetCore.Mvc;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;
using System.Collections.Generic;

namespace MinVoiCe.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public IActionResult Index()
        {
            //refactor to include other items and pull them from viewbag
            List<Client> Clients = ClientData.GetAll();

            //ViewBag.Clients = ClientData.GetAll();
            ViewBag.Projects = ProjectData.GetAll();
            ViewBag.Worktimes = WorktimeData.GetAll();

            return View(Clients);
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
                List<Worktime> ProjectWorktimes = new List<Worktime>();

                foreach (Worktime aWorktime in WorktimeData.GetAll())
                {
                    if (aWorktime.Project.ProjectId == invoiceViewModel.ProjectId)
                    {
                        ProjectWorktimes.Add(aWorktime);
                    }
                }

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


        