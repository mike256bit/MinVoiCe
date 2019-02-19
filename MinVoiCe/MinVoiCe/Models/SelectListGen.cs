using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class SelectListGen
    {
        public static List<SelectListItem> SelectProjects(IList<Project> ProjectList)
        {
            List<SelectListItem> SelectProjects = new List<SelectListItem>();

            foreach (Project aProject in ProjectList)
            {
                SelectProjects.Add(new SelectListItem
                {
                    Value = aProject.ProjectID.ToString(),
                    Text = aProject.Name
                });
            }

            //SelectProjects.Add(new SelectListItem

            //{
            //    Value = "0",
            //    Text = "Add Project...",
            //});

            return SelectProjects;
        }



    }
}
