using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Models
{
    public class InvoiceData
    {

        private static List<Invoice> invoiceList = new List<Invoice>();

        //Add
        public static void Add(Invoice newInvoice)
        {
            invoiceList.Add(newInvoice);
        }

        public static Invoice GetbyID(int id)
        {
            return invoiceList.Single(x => x.InvoiceId == id);
        }
    }

}
