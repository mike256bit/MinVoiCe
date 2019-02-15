using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinVoiCe.data;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;

namespace MinVoiCe.Controllers
{
    public class ClientController : Controller
    {
        //dbContext Setup
        private MinvoiceDbContext context;
        public ClientController(MinvoiceDbContext dbContext)
        {
            context = dbContext;
        }

        //Send user to "add client" form
        public IActionResult AddClient()
        {
            AddClientViewModel addClientViewModel = new AddClientViewModel();

            addClientViewModel.Clients = context.Clients.ToList();

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

                context.Clients.Add(newClient);

                ViewBag.SingleClient = newClient;

                return View();
            }

            return View("AddClient", addClientViewModel);

        }

        //Single client page
        [HttpGet]
        public IActionResult Client(int id)
        {

            ViewBag.SingleClient = context.Clients.Single(c => c.ClientID == id);

            return View();
        }

    }
}
