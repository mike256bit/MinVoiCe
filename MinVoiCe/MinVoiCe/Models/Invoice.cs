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
        public float TotalAmount { get; set; }
       
        //default constructor
        public Invoice()
        {
            InvoiceId = nextId;
            nextId++;
        }

        public void Total()
        {
            int HoursSum = 0;
            foreach (Worktime aWorktime in Worktimes)
            {
                HoursSum += aWorktime.Hours;
            }

            TotalAmount = HoursSum * Project.Rate;

        }
    }
}