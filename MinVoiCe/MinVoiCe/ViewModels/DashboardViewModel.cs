using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.ViewModels
{
    public class DashboardViewModel
    {
        public int ProjectID { get; set; }
        public int WeekId { get; set; }

        public IList<Project> Projects { get; set; }
        public List<Worktime> Worktimes { get; set; }

        //For dashboard view
        public string DashboardTitle { get; set; }
        public List<SelectListItem> SelectProjects { get; set; }

        //For Adding Time
        [Required]
        [Range(.5, 100)]
        public double Hours { get; set; }

        [Required]
        public string Description { get; set; }

        public List<SelectListItem> SelectWeeks { get; set; }

        //Default Constructor
        //public DashboardViewModel()
        //{

        //    SelectProjects = ProjectData.SelectProjects();
        //    DashboardTitle = "All Projects";
        //    SelectWeeks = WeekNumber.SelectWeeks();

        //}

        public DashboardViewModel (IList<Project> Projects, int id)
        {

            SelectProjects = ProjectData.SelectProjects(Projects);
            ProjectID = id;
            SelectWeeks = WeekNumber.SelectWeeks();
            WeekId = WeekNumber.CurrentWeek;
        }
    }
}
