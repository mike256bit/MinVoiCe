using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;

namespace MinVoiCe.Controllers
{
    public class ProjectController : Controller
    {
        //Send user to "add project" form
        public IActionResult AddProject()
        {
            AddProjectViewModel addProjectViewModel = new AddProjectViewModel();

            return View(addProjectViewModel);
        }

        //Add the new project and return single project page view
        [HttpPost]
        public IActionResult Project(AddProjectViewModel addProjectViewModel)
        {

            if (ModelState.IsValid)
            {
                Project newProject = new Project
                {
                    Name = addProjectViewModel.Name,
                    Description = addProjectViewModel.Description,
                    Rate = addProjectViewModel.Rate,
                };

                newProject.Client = ClientData.GetbyID(addProjectViewModel.ClientId);

                ProjectData.Add(newProject);
                ViewBag.SingleProject = newProject;

                return View();
            }

            return View("AddProject", addProjectViewModel);
        }

        [HttpGet]
        public IActionResult Project(int id)
        {
            ViewBag.SingleProject = ProjectData.GetbyID(id);

            return View();
        }
    }
}
