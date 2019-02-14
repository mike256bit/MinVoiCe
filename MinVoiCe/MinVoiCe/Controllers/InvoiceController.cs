using Microsoft.AspNetCore.Mvc;
using MinVoiCe.Models;
using MinVoiCe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinVoiCe.Controllers
{
    public class InvoiceController : Controller
    {

        public IActionResult Create()
        {
            InvoiceViewModel invoiceViewModel = new InvoiceViewModel();

            if (invoiceViewModel.SelectProjects.Count == 0)
            {
                return Redirect("/");
            }

            return View(invoiceViewModel);
        }

        [HttpPost]
        public IActionResult Generator(InvoiceViewModel invoiceViewModel)
        {

            if (ModelState.IsValid)
            {
                Invoice newInvoice = new Invoice(invoiceViewModel.ProjectId);

                if (newInvoice.Worktimes.Count == 0)
                {
                    return Redirect("/");
                }

                newInvoice.Total();

                InvoiceData.Add(newInvoice);

                ConfirmInvoiceViewModel confirmInvoiceViewModel = new ConfirmInvoiceViewModel(newInvoice);

                return View("ConfirmInvoice", confirmInvoiceViewModel);

            }

            return View("Invoice", invoiceViewModel);
        }

        [HttpPost]
        public IActionResult Update(ConfirmInvoiceViewModel confirmInvoiceViewModel, int[] RemoveWorkTimeIDs)
        {
            List<Worktime> RemoveList = new List<Worktime>();

            Invoice updatedInvoice = InvoiceData.GetbyID(confirmInvoiceViewModel.InvoiceId);

            foreach (int i in RemoveWorkTimeIDs)
            {
                foreach(Worktime aWorktime in updatedInvoice.Worktimes)
                {
                    if(aWorktime.WorktimeId == i)
                    {
                        RemoveList.Add(aWorktime);
                    }
                }
            }

            foreach(Worktime aWorktime in RemoveList)
            {
                updatedInvoice.Worktimes.Remove(aWorktime);
            }
            updatedInvoice.Total();
            
            ConfirmInvoiceViewModel confirmInvoiceViewModel2 = new ConfirmInvoiceViewModel(updatedInvoice);

            return View("ConfirmInvoice", confirmInvoiceViewModel2);

        }
    }
}
