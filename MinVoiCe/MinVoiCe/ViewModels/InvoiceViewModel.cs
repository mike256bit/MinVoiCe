using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.ViewModels
{
    public class InvoiceViewModel
    {

        public int ProjectId { get; set; }
        public List<SelectListItem> SelectProjects { get; set; }

        //Constructor
        public InvoiceViewModel()
        {
            List<Project> Projects = ProjectData.GetAll();
            SelectProjects = new List<SelectListItem>();

            foreach (Project aProject in Projects)
            {
                SelectProjects.Add(new SelectListItem
                {
                    Value = aProject.ProjectId.ToString(),
                    Text = aProject.Name
                });
            }
        }
    }
}
