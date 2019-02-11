using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class ProjectData
    {

        private static List<Project> projectList = new List<Project>();
        public static bool IsLoaded = false;

        //GetAll
        public static List<Project> GetAll()
        {
            return projectList;
        }

        //Add
        public static void Add(Project newProject)
        {
            projectList.Add(newProject);
        }

        //GetbyName
        public static Project GetbyID(int id)
        {
            return projectList.Single(x => x.ProjectId == id);
        }

        //SelectListItem Generator
        public static List<SelectListItem> SelectProjects()
        {
            List<SelectListItem> SelectProjects = new List<SelectListItem>();

            foreach (Project aProject in projectList)
            {
                SelectProjects.Add(new SelectListItem
                {
                    Value = aProject.ProjectId.ToString(),
                    Text = aProject.Name
                });
            }

            return SelectProjects;

        }

        //SelectList with Current Project Removed
        public static List<SelectListItem> SelectProjects(int id)
        {
            List<SelectListItem> SelectProjects = new List<SelectListItem>();

            foreach (Project aProject in projectList)
            {
                    SelectProjects.Add(new SelectListItem
                    {
                        Value = aProject.ProjectId.ToString(),
                        Text = aProject.Name,
                        Selected = (aProject.ProjectId == id)
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
        public static void LoadProjects()
        {
            if (ClientData.IsLoaded)
            {
                Project projdummy1 = new Project
                {
                    Name = "Smart Tackle Box",
                    Description = "Bluetooth enabled self-organizing tackle box for different kinds of fishing environments.",
                    Rate = 50.00F,
                    Client = ClientData.GetbyID(1)
                };

                Project projdummy2 = new Project
                {
                    Name = "SuperSonic Reel",
                    Description = "Ultrafast reel which using a collapsing black hole to draw in the line.",
                    Rate = 110.00F,
                    Client = ClientData.GetbyID(1)
                };

                projectList.Add(projdummy1);
                projectList.Add(projdummy2);
                IsLoaded = true;
            }
           
        }
    }
}
