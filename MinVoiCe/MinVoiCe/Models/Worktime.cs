using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class Worktime
    {

        private static int nextId = 1;
        public int WorktimeId { get; set; }
        public double Hours { get; set; }
        public string WeekRange { get; set; }
        public string Description { get; set; }
        public Project Project { get; set; }
        public double Amount { get; set; }

        //default constructor
        public Worktime()
        {
            WorktimeId = nextId;
            nextId++;
        }
    }
}

