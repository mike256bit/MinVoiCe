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
        [Required(ErrorMessage = "Please enter a client name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a point of contact.")]
        public string PointOfContact { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-]?([0-9]{3})[-]?([0-9]{4})$", ErrorMessage = "Not a valid phone number. (Ex: ###-###-####)")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string EMail { get; set; }

        public string AddressStreet { get; set; }

        public string AddressCityZip { get; set; }

        public List<Client> Clients { get; set; }
    }
}
