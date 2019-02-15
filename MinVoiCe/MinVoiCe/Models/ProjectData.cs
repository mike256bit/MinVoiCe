using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class ProjectData
    {
        //SelectListItem Generator
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

            SelectProjects.Add(new SelectListItem
            {
                Value = "0",
                Text = "Add Project...",
            });

            return SelectProjects;

        }

        //Load Dummy Projects:
        //public static void LoadProjects()
        //{
        //    if (ClientData.IsLoaded)
        //    {
        //        Project projdummy1 = new Project
        //        {
        //            Name = "Smart Tackle Box",
        //            Description = "Bluetooth enabled self-organizing tackle box for different kinds of fishing environments.",
        //            Rate = 50.00F,
        //            Client = ClientData.GetbyID(1)
        //        };

        //        Project projdummy2 = new Project
        //        {
        //            Name = "SuperSonic Reel",
        //            Description = "Ultrafast reel which using a collapsing black hole to draw in the line.",
        //            Rate = 110.00F,
        //            Client = ClientData.GetbyID(1)
        //        };

        //        projectList.Add(projdummy1);
        //        projectList.Add(projdummy2);
        //        IsLoaded = true;
        //    }

    }
}
