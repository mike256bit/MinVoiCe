using Microsoft.AspNetCore.Mvc;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;
using System.Collections.Generic;

namespace MinVoiCe.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public IActionResult Index(int id)
        {
            if (ClientData.IsLoaded == false)
            {
                ClientData.LoadClients();
            };

            if (ProjectData.IsLoaded == false)
            {
                ProjectData.LoadProjects();
            }

            DashboardViewModel dashboardViewModel = new DashboardViewModel(id);

            //refactor to include other items and pull them from viewbag
            dashboardViewModel.Clients = ClientData.GetAll();
            dashboardViewModel.Projects = ProjectData.GetAll();

            
            if (id != 0)
            {
                dashboardViewModel.Worktimes = WorktimeData.GetbyProjectID(id);
                dashboardViewModel.DashboardTitle = ProjectData.GetbyID(id).Name;

            }

            else
            {
                dashboardViewModel.Worktimes = WorktimeData.GetAll();
                dashboardViewModel.DashboardTitle = "Showing all Projects";
            }

            return View(dashboardViewModel);
        }

        //Dashboard Change
      
        [HttpPost]
        public IActionResult Dashboard(DashboardViewModel dashboardViewModel)
        {
            if (dashboardViewModel.ProjectId == 0)
            {
                return Redirect("/Project/AddProject");
            }

            return Redirect("/?id=" + dashboardViewModel.ProjectId);
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

                return Redirect("/?id="+addTimeViewModel.ProjectId);
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


        