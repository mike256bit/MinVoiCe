
using MinVoiCe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.ViewModels
{
    public class ConfirmInvoiceViewModel
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public ConfirmInvoiceViewModel()
        {

        }

        public ConfirmInvoiceViewModel(Invoice anInvoice)
        {
            Invoice = anInvoice;
            InvoiceId = anInvoice.InvoiceId;
        }
    }
}
