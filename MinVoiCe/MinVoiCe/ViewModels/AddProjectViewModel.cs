using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.ViewModels
{
    public class AddProjectViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public float Rate { get; set; }

        public int ClientId { get; set; }

        public List<SelectListItem> SelectClients { get; set; }

        //Constructor
        public AddProjectViewModel()
        {
            List<Client> Clients = ClientData.GetAll();
            SelectClients = new List<SelectListItem>();

            foreach (Client aClient in Clients)
            {
                SelectClients.Add(new SelectListItem
                {
                    Value = aClient.ClientId.ToString(),
                    Text = aClient.Name
                });
            }

        }

    }
}
