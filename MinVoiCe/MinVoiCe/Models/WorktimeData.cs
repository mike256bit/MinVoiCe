using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class WorktimeData
    {

        private static List<Worktime> worktimeList = new List<Worktime>();

        //GetAll
        public static List<Worktime> GetAll()
        {
            return worktimeList;
        }

        //Add
        public static void Add(Worktime newWorktime)
        {
            worktimeList.Add(newWorktime);
        }

        //Get by ID
        public static Worktime GetbyID(int id)
        {
            return worktimeList.Single(x => x.WorktimeId == id);
        }

        //Get by Project ID
        public static List<Worktime> GetbyProjectID(int id)
        {
            List<Worktime> ProjectWorktimes = new List<Worktime>();

            foreach(Worktime aWorktime in worktimeList)
            {
                if (aWorktime.Project.ProjectId == id && aWorktime.IncludeInNextInvoice)
                {
                    ProjectWorktimes.Add(aWorktime);
                }
            }

            return ProjectWorktimes;
        }
    }
}
