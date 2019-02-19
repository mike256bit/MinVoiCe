using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.data;
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

        public int ClientID { get; set; }

        public List<SelectListItem> SelectClients { get; set; }

        //Constructor

        public AddProjectViewModel()
        {

        }

        public AddProjectViewModel(List<Client> clients)
        {
            //Generate dropdown for clients
            SelectClients = new List<SelectListItem>();
            foreach (Client aClient in clients)
            {
                SelectClients.Add(new SelectListItem
                {
                    Value = aClient.ClientID.ToString(),
                    Text = aClient.Name
                });
            }

        }

    }
}
