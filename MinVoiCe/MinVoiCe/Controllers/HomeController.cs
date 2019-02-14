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
                WeekNumber.WeekGenerator();
            };

            if (ProjectData.IsLoaded == false)
            {
                ProjectData.LoadProjects();
            }

            DashboardViewModel dashboardViewModel = new DashboardViewModel(id);

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
        public IActionResult DashWorkTime(DashboardViewModel dashboardViewModel)
        {
            if (ModelState.IsValid)
            {
                Worktime newWorktime = new Worktime
                {
                    Hours = dashboardViewModel.Hours,
                    WeekRange = WeekNumber.WeekDict[dashboardViewModel.WeekId],
                    Description = dashboardViewModel.Description
                };

                newWorktime.Project = ProjectData.GetbyID(dashboardViewModel.ProjectId);
                newWorktime.Amount = newWorktime.Hours * (double)newWorktime.Project.Rate;
                WorktimeData.Add(newWorktime);

                return Redirect("/?id=" + dashboardViewModel.ProjectId);
            }

            AddTimeViewModel addTimeViewModel = new AddTimeViewModel
            {
                Hours = dashboardViewModel.Hours,
                WeekId = dashboardViewModel.WeekId,
                Description = dashboardViewModel.Description,
                ProjectId = dashboardViewModel.ProjectId
            };

            return View("Addtime", addTimeViewModel);
        }
    

        [HttpPost]
        public IActionResult Worktime(AddTimeViewModel addTimeViewModel)
        {

            if (ModelState.IsValid)
            {
                Worktime newWorktime = new Worktime
                {
                    Hours = addTimeViewModel.Hours,
                    WeekRange = WeekNumber.WeekDict[addTimeViewModel.WeekId],
                    Description = addTimeViewModel.Description
                };

                newWorktime.Project = ProjectData.GetbyID(addTimeViewModel.ProjectId);
                newWorktime.Amount = newWorktime.Hours * (double)newWorktime.Project.Rate;
                WorktimeData.Add(newWorktime);


                return Redirect("/?id="+addTimeViewModel.ProjectId);
            }

            return View("Addtime", addTimeViewModel);
        }

    }

}


        