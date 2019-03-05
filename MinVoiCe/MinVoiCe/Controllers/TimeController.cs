using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinVoiCe.data;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MinVoiCe.Controllers
{
    public class TimeController : Controller
    {
        //dbContext Setup
        private MinvoiceDbContext context;
        public TimeController(MinvoiceDbContext dbContext)
        {
            context = dbContext;
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
                newWorktime.OpenStatus = true;

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

            return View("AddTime", addTimeViewModel);
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
                newWorktime.OpenStatus = true;

                context.Worktimes.Add(newWorktime);
                context.SaveChanges();

                return Redirect("/?id=" + addTimeViewModel.ProjectID);
            }

            addTimeViewModel.SelectProjects = SelectListGen.SelectProjects(context.Projects.ToList());

            return View("AddTime", addTimeViewModel);
        }

    }
}
