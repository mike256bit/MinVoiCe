using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            //Initialize week number generator
            if (WeekNumber.IsLoaded == false)
            {
                WeekNumber.WeekGenerator();
                WeekNumber.IsLoaded = true;
            };

            DashboardViewModel dashboardViewModel = new DashboardViewModel(context.Projects.ToList(), id);
                       
            if (id != 0)
            {

                dashboardViewModel.Worktimes = context.Worktimes
                    .Where(w => w.ProjectID == id)
                    .Include(w => w.Project).ToList();

                dashboardViewModel.DashboardTitle = context.Projects.Single(p => p.ProjectID == id).Name;
            }

            else
            {
                dashboardViewModel.Worktimes = context.Worktimes.ToList();
                dashboardViewModel.DashboardTitle = "Showing all Projects";


                dashboardViewModel.SelectProjects.Add(new SelectListItem
                    {
                        Value = "0",
                        Text = "Add Project...",
                    });

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

        //Go to Add Time form
        public IActionResult AddTime()
        {
            AddTimeViewModel addTimeViewModel = new AddTimeViewModel();

            //Generate list of projects
            addTimeViewModel.SelectProjects = SelectListGen.SelectProjects(context.Projects.ToList());

            return View(addTimeViewModel);
        }

        [HttpPost]
        public IActionResult DashWorkTime(DashboardViewModel dashboardViewModel)
        {
            if (ModelState.IsValid)
            {
                Project newProject = context.Projects.Single(p => p.ProjectID == dashboardViewModel.ProjectID);

                Worktime newWorktime = new Worktime
                {
                    Hours = dashboardViewModel.Hours,
                    WeekRange = WeekNumber.WeekDict[dashboardViewModel.WeekId],
                    Description = dashboardViewModel.Description,
                    Project = newProject
                };

                newWorktime.Amount = newWorktime.Hours * (double)newWorktime.Project.Rate;

                context.Worktimes.Add(newWorktime);
                context.SaveChanges();

                return Redirect("/?id=" + dashboardViewModel.ProjectID);
            }


            AddTimeViewModel addTimeViewModel = new AddTimeViewModel
            {
                Hours = dashboardViewModel.Hours,
                WeekId = dashboardViewModel.WeekId,
                Description = dashboardViewModel.Description,
                ProjectID = dashboardViewModel.ProjectID
            };

            addTimeViewModel.SelectProjects = SelectListGen.SelectProjects(context.Projects.ToList());

            return View("Addtime", addTimeViewModel);
        }
    

        [HttpPost]
        public IActionResult Worktime(AddTimeViewModel addTimeViewModel)
        {

            if (ModelState.IsValid)
            {
                Project newProject = context.Projects.Single(p => p.ProjectID == addTimeViewModel.ProjectID);

                Worktime newWorktime = new Worktime
                {
                    Hours = addTimeViewModel.Hours,
                    WeekRange = WeekNumber.WeekDict[addTimeViewModel.WeekId],
                    Description = addTimeViewModel.Description,
                    Project = newProject
                };

                newWorktime.Amount = newWorktime.Hours * (double)newWorktime.Project.Rate;

                context.Worktimes.Add(newWorktime);
                context.SaveChanges();

                return Redirect("/?id="+addTimeViewModel.ProjectID);
            }

            addTimeViewModel.SelectProjects = SelectListGen.SelectProjects(context.Projects.ToList());

            return View("Addtime", addTimeViewModel);
        }

    }

}


        