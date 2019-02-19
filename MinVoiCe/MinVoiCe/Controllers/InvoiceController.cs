using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinVoiCe.data;
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
        //dbContext Setup
        private MinvoiceDbContext context;
        public InvoiceController(MinvoiceDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Create()
        {
            InvoiceViewModel invoiceViewModel = new InvoiceViewModel(context.Projects.ToList());

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
                Project newProject = context.Projects
                    .Include(p => p.Client)
                    .Single(p => p.ProjectID == invoiceViewModel.ProjectID);

                Invoice newInvoice = new Invoice
                {
                    CurrentDate = DateTime.Today.ToString("d"),
                    Project = newProject
                };
                
                IList<Worktime> openWorktimes = context.Worktimes
                    .Where(w => w.ProjectID == invoiceViewModel.ProjectID)
                    .Where(w => w.OpenStatus == true)
                    .Include(w => w.Project)
                    .Include(w => w.Project.Client)
                    .ToList();

                if (openWorktimes.Count == 0)
                {
                    return Redirect("/");
                }

                newInvoice.Worktimes = openWorktimes;

                foreach(Worktime aWorktime in openWorktimes)
                {
                    newInvoice.TotalAmount += aWorktime.Amount;
                    aWorktime.OpenStatus = false;
                }
                 
                context.Invoices.Add(newInvoice);
                context.SaveChanges();

                ConfirmInvoiceViewModel confirmInvoiceViewModel = new ConfirmInvoiceViewModel(newInvoice);

                return View("ConfirmInvoice", confirmInvoiceViewModel);

            }

            return View("Invoice", invoiceViewModel);
        }

        [HttpPost]
        public IActionResult Update(ConfirmInvoiceViewModel confirmInvoiceViewModel, int[] RemoveWorkTimeIDs)
        {
            List<Worktime> RemoveList = new List<Worktime>();

            Invoice updatedInvoice = context.Invoices
                .Include(inv => inv.Project.Client)
                .Include(inv => inv.Worktimes)
                .Single(inv => inv.InvoiceID == confirmInvoiceViewModel.InvoiceID);

            foreach (int i in RemoveWorkTimeIDs)
            {
                foreach(Worktime aWorktime in updatedInvoice.Worktimes)
                {
                    if(aWorktime.WorktimeID == i)
                    {
                        RemoveList.Add(aWorktime);
                    }
                }
            }

            foreach(Worktime aWorktime in RemoveList)
            {
                updatedInvoice.Worktimes.Remove(aWorktime);
                updatedInvoice.TotalAmount -= aWorktime.Amount;
                aWorktime.OpenStatus = true;
            }

            context.SaveChanges();
            
            ConfirmInvoiceViewModel confirmInvoiceViewModel2 = new ConfirmInvoiceViewModel(updatedInvoice);

            return View("ConfirmInvoice", confirmInvoiceViewModel2);

        }
    }
}
