using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.data;
using MinVoiCe.Models;
using System.Collections.Generic;


namespace MinVoiCe.ViewModels
{
    public class InvoiceViewModel
    {
        //dbContext Setup
        private MinvoiceDbContext context;
        public InvoiceViewModel(MinvoiceDbContext dbContext)
        {
            context = dbContext;
        }

        public int ProjectId { get; set; }
        public List<SelectListItem> SelectProjects { get; set; }

        //Constructor
        public InvoiceViewModel(IList<Project> ProjectList)
        {
            SelectProjects = ProjectData.SelectProjects(ProjectList);
        }
    }
}
