using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class Worktime
    {

        public int WorktimeID { get; set; }
        public double Hours { get; set; }
        public string WeekRange { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public bool IncludeInNextInvoice { get; set; }

        public int ProjectID { get; set; }
        public Project Project { get; set; }

        public void ToggleInclude(bool state)
        {
            IncludeInNextInvoice = state;
        }
    }
}

