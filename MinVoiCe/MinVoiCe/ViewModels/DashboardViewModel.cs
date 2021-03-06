﻿using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IList<Worktime> Worktimes { get; set; }

        //For dashboard view
        public string DashboardTitle { get; set; }
        public List<SelectListItem> SelectProjects { get; set; }

        //For Adding Time
        [Required]
        [Range(.25, 100)]
        public double Hours { get; set; }

        [Required]
        public string Description { get; set; }

        public List<SelectListItem> SelectWeeks { get; set; }

        //Default Constructor
        public DashboardViewModel()
        {

        }

        public DashboardViewModel (IList<Project> projects, int id)
        {

            //Projects = projects;
            SelectProjects = SelectListGen.SelectProjects(projects);
            ProjectID = id;
            SelectWeeks = WeekNumber.SelectWeeks();
            WeekId = WeekNumber.CurrentWeek;
        }
    }
}
