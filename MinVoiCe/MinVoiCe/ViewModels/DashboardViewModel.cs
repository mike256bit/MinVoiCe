using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.ViewModels
{
    public class DashboardViewModel
    {
        public int ProjectId { get; set; }

        public List<Client> Clients { get; set; }
        public List<Project> Projects { get; set; }
        public List<Worktime> Worktimes { get; set; }
        public string CurrentProject { get; set; }
        
        public List<SelectListItem> SelectProjects { get; set; }

        //Constructor
        public DashboardViewModel()
        {

            SelectProjects = ProjectData.SelectProjects();

        }
    }
}
