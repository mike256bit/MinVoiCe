using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.ViewModels
{
    public class AddTimeViewModel
    {
        [Required]
        [Range(.25, 100)]
        public double Hours { get; set; }

        public int WeekId { get; set; }

        [Required]
        public string Description { get; set; }

        public int ProjectID { get; set; }

        public List<SelectListItem> SelectProjects { get; set; }
        public List<SelectListItem> SelectWeeks { get; set; }

        //Constructor

        public AddTimeViewModel()
        {
            SelectWeeks = WeekNumber.SelectWeeks();
            WeekId = WeekNumber.CurrentWeek;
        }
    }
}
