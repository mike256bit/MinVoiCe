using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class Invoice
    {

        private static int nextId = 1;
        public int InvoiceId { get; set; }
        public List<Worktime> Worktimes { get; set; }
        public Project Project { get; set; }
        public double TotalAmount { get; set; }
        public string CurrentDate { get; set; }

        //default constructor
        public Invoice(int id)
        {
            InvoiceId = nextId;
            nextId++;
            CurrentDate = DateTime.Today.ToString("d");
            //Project = ProjectData.GetbyID(id);
            //Worktimes = WorktimeData.GetbyProjectID(id);
        }

        public void Total()
        {
            TotalAmount = 0;
            foreach (Worktime aWorktime in Worktimes)
            {
                TotalAmount += aWorktime.Amount;
            }
        }
    }
}