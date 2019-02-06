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
            //Send users here upon login - this is the dashboard view
            //Display the home page, which has the short list of projects, time entries and time entry form

            List<Client> Clients = ClientData.GetAll();

            //ViewBag.Clients = ClientData.GetAll();
            ViewBag.Projects = ProjectData.GetAll();

            return View(Clients);
        }

        //Home/AddTime
        public IActionResult AddTime()
        {
            //When users hit the add time button, take the form data, validate it, and add it to the worktime DBset
            //Redirect to the dashboard

            return Content("Home/Index");
        }

        //Send user to "add project" form
        public IActionResult AddProject()
        {
            return View();
        }

        //Add the new project and return single project page view
        [HttpPost]
        public IActionResult Project(Project newProject)
        {
            ProjectData.Add(newProject);
            ViewBag.SingleProject = newProject;

            return View();
        }

        [HttpGet]
        public IActionResult Project(int id)
        {
            ViewBag.SingleProject = ProjectData.GetbyID(id);

            return View();
        }

        //Send user to "add client" form
        public IActionResult AddClient()
        {
            AddClientViewModel addClientViewModel = new AddClientViewModel();

            return View(addClientViewModel);
        }

        //Add the new client and return single client page view
        [HttpPost]
        public IActionResult Client(AddClientViewModel addClientViewModel)
        {

            if (ModelState.IsValid)
            {
                Client newClient = new Client
                {
                    Name = addClientViewModel.Name,
                    PointOfContact = addClientViewModel.PointOfContact,
                    Phone = addClientViewModel.Phone,
                    EMail = addClientViewModel.EMail,
                    AddressStreet = addClientViewModel.AddressStreet,
                    AddressCityZip = addClientViewModel.AddressCityZip
                };

                ClientData.Add(newClient);
                ViewBag.SingleClient = newClient;

                return View();
            }

            return View("AddClient", addClientViewModel);
            
        }

        //Single client page
        [HttpGet]
        public IActionResult Client(int id)
        {

            ViewBag.SingleClient = ClientData.GetbyID(id);

            return View();
        }

    }

}


        