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
    }
}
