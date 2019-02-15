using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinVoiCe.data;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MinVoiCe.Controllers
{
    public class HomeController : Controller
    {
        //dbContext Setup
        private MinvoiceDbContext context;
        public HomeController (MinvoiceDbContext dbContext)
        {
            context = dbContext;
        }
        
        //Home/Index
        public IActionResult Index(int id)
        {

            if (ClientData.IsLoaded == false)
            {
                //ClientData.LoadClients();
                WeekNumber.WeekGenerator();
                ClientData.IsLoaded = true;
            };

            //if (ProjectData.IsLoaded == false)
            //{
            //    ProjectData.LoadProjects();
            //}

            DashboardViewModel dashboardViewModel = new DashboardViewModel(context.Projects.ToList(), id);

            //dashboardViewModel.Clients = context.Clients.ToList();
            //dashboardViewModel.Projects = context.Projects.Include(p => p.Client).ToList();
                        
            if (id != 0)
            {
                dashboardViewModel.Worktimes = WorktimeData.GetbyProjectID(id);

                dashboardViewModel.DashboardTitle = context.Projects.Single(p => p.ProjectID == id).Name;
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
            if (dashboardViewModel.ProjectID == 0)
            {
                return Redirect("/Project/AddProject");
            }

            return Redirect("/?id=" + dashboardViewModel.ProjectID);
        }

        //Home/AddTime


        public IActionResult AddTime()
        {
            AddTimeViewModel addTimeViewModel = new AddTimeViewModel(context.Projects.ToList());

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

                newWorktime.Project = context.Projects.Single(p => p.ProjectID == dashboardViewModel.ProjectID);
                newWorktime.Amount = newWorktime.Hours * (double)newWorktime.Project.Rate;
                WorktimeData.Add(newWorktime);

                return Redirect("/?id=" + dashboardViewModel.ProjectID);
            }

            AddTimeViewModel addTimeViewModel = new AddTimeViewModel
            {
                Hours = dashboardViewModel.Hours,
                WeekId = dashboardViewModel.WeekId,
                Description = dashboardViewModel.Description,
                ProjectId = dashboardViewModel.ProjectID
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

                newWorktime.Project = context.Projects.Single(p => p.ProjectID == addTimeViewModel.ProjectId);
                newWorktime.Amount = newWorktime.Hours * (double)newWorktime.Project.Rate;
                WorktimeData.Add(newWorktime);


                return Redirect("/?id="+addTimeViewModel.ProjectId);
            }

            return View("Addtime", addTimeViewModel);
        }

    }

}


        