using Microsoft.AspNetCore.Mvc;
using MinVoiCe.Models;

namespace MinVoiCe.Controllers
{
    public class HomeController : Controller
    {
        //Home/Index
        public IActionResult Index()
        {
            //Send users here upon login - this is the dashboard view
            //Display the home page, which has the short list of projects, time entries and time entry form

            return Content("Home/Index");
        }

        //Home/AddTime
        public IActionResult AddTime()
        {
            //When users hit the add time button, take the form data, validate it, and add it to the worktime DBset
            //Redirect to the dashboard

            return Content("Home/Index");
        }

        //Home/AddProject
        public IActionResult AddProject()
        {
            //When user clicks "add project" button, send them to the form page for adding a project.

            return Content("Home/AddProject");
        }

        //Home/ProjectSubmit
        public IActionResult ProjectSubmit()
        {
            //When user fills out form and hits submit, validate the data, add the project to the project DBset and go to single project page

            return Content("Home/SingleProject?ID=##");
        }


    }

}


        