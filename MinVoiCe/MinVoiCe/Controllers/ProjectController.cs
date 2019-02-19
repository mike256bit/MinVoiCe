using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinVoiCe.data;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;

namespace MinVoiCe.Controllers
{
    public class ProjectController : Controller
    {

        //dbContext Setup
        private MinvoiceDbContext context;
        public ProjectController(MinvoiceDbContext dbContext)
        {
            context = dbContext;
        }

        //Send user to "add project" form
        public IActionResult AddProject()
        {
            AddProjectViewModel addProjectViewModel = new AddProjectViewModel(context.Clients.ToList());

            return View(addProjectViewModel);
        }

        //Add the new project and return single project page view
        [HttpPost]
        public IActionResult Project(AddProjectViewModel addProjectViewModel)
        {

            if (ModelState.IsValid)
            {
                Client newClient = context.Clients.Single(c => c.ClientID == addProjectViewModel.ClientID);

                Project newProject = new Project
                {
                    Name = addProjectViewModel.Name,
                    Description = addProjectViewModel.Description,
                    Rate = addProjectViewModel.Rate,
                    Client = newClient
                };

                context.Projects.Add(newProject);
                context.SaveChanges();

                ViewBag.SingleProject = newProject;

                return View();
            }

            return View("AddProject", addProjectViewModel);
        }

        [HttpGet]
        public IActionResult Project(int id)
        {
            ViewBag.SingleProject = context.Projects.Include(p => p.Client).Single(p => p.ProjectID == id);

            return View();
        }
    }
}
