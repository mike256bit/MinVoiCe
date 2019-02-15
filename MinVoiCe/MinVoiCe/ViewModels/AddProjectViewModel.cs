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
        //dbContext Setup
        private MinvoiceDbContext context;
        public AddProjectViewModel(MinvoiceDbContext dbContext)
        {
            context = dbContext;
        }

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
            List<Client> Clients = context.Clients.ToList();
            SelectClients = new List<SelectListItem>();

            foreach (Client aClient in Clients)
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
