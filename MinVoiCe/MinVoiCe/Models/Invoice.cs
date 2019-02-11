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
        public Invoice()
        {
            InvoiceId = nextId;
            nextId++;
            CurrentDate = DateTime.Today.ToString("d");
        }

        public void Total()
        {
            foreach (Worktime aWorktime in Worktimes)
            {
                TotalAmount += aWorktime.Amount;
            }
        }
    }
}