using MinVoiCe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.ViewModels
{
    public class AddClientViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string PointOfContact { get; set; }

        [Required]
        [Phone] //Lookup better phone validation techniques.
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string EMail { get; set; }

        public string AddressStreet { get; set; }

        public string AddressCityZip { get; set; }

        public List<Client> Clients { get; set; }
    }
}
