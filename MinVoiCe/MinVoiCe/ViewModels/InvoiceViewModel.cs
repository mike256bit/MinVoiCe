using Microsoft.AspNetCore.Mvc.Rendering;
using MinVoiCe.data;
using MinVoiCe.Models;
using System.Collections.Generic;


namespace MinVoiCe.ViewModels
{
    public class InvoiceViewModel
    {

        public int ProjectID { get; set; }
        public IList<Invoice> PreviousInvoices { get; set; }

        public List<SelectListItem> SelectProjects { get; set; }

        //Constructor
        public InvoiceViewModel()
        {

        }

        public InvoiceViewModel(IList<Project> ProjectList)
        {
            SelectProjects = SelectListGen.SelectProjects(ProjectList);
        }
    }
}
