using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;

namespace MinVoiCe.Controllers
{
    public class ClientController : Controller
    {

        //Send user to "add client" form
        public IActionResult AddClient()
        {
            AddClientViewModel addClientViewModel = new AddClientViewModel();
            addClientViewModel.Clients = ClientData.GetAll();

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
