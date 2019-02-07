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
        public int Hours { get; set; }
        public string Date { get; set; } //date is probably going to become a date-range or WeekId
        public string Description { get; set; }
        public Project Project { get; set; }

        //default constructor
        public Worktime()
        {
            WorktimeId = nextId;
            nextId++;
        }
    }
}

