using Microsoft.AspNetCore.Mvc;
using MinVoiCe.Models;
using System.Collections.Generic;

namespace MinVoiCe.Controllers
{
    public class HomeController : Controller
    {

        private static List<Client> ClientList = new List<Client>();

        //Home/Index
        public IActionResult Index()
        {
            //Send users here upon login - this is the dashboard view
            //Display the home page, which has the short list of projects, time entries and time entry form

            ViewBag.Clients = ClientList;
            return View();
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

            return Content("Home/Project?ID=##");
        }

        public IActionResult AddClient()
        {
            //When user clicks "add client" button, send them to the form page for adding a client.

            return View();
        }

        //Home/ClientSubmit
        public IActionResult Client(string name, string pointOfContact, string phone, string email, string addressStreet, string addressCityZip)
        {
            //When user fills out form and hits submit, validate the data, add the client to the client DBset and go to single client page, which will have a list of associated projects on it

            Client NewClient = new Client {
                Name = name,
                PointOfContact = pointOfContact,
                Phone = phone,
                EMail = email,
                AddressStreet = addressStreet,
                AddressCityZip = addressCityZip
                };

            ClientList.Add(NewClient);
            ViewBag.SingleClient = NewClient;
                   
            return View();
        }

    }

}


        