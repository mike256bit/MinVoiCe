using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class ProjectData
    {

        private static List<Project> projectList = new List<Project>();

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
    }
}
