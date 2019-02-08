using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.Models;
using System.Collections.Generic;


namespace MinVoiCe.ViewModels
{
    public class InvoiceViewModel
    {

        public int ProjectId { get; set; }
        public List<SelectListItem> SelectProjects { get; set; }

        //Constructor
        public InvoiceViewModel()
        {
            SelectProjects = ProjectData.SelectProjects();
        }
    }
}
