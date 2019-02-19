using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class Invoice
    {

        public int InvoiceID { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public double TotalAmount { get; set; }
        public string CurrentDate { get; set; }

        public IList<Worktime> Worktimes { get; set; }

    }
}
//CurrentDate = DateTime.Today.ToString("d");

    //put totaling function outside of class:
    //foreach (Worktime aWorktime in Worktimes)
    //        {
    //            TotalAmount += aWorktime.Amount;
    //        }