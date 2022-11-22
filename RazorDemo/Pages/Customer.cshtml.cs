using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDemo.Models;

namespace RazorDemo.Pages
{
    public class CustomerModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }

        DatabaseContext _Context;

        public CustomerModel(DatabaseContext databasecontext)
        {
            _Context = databasecontext;
        }

        public void OnGet()
        {
            
        }

        public ActionResult OnPost()
        {
            var customer = Customer;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            customer.CustomerID = 3;
            var result = _Context.Add(customer);
            _Context.SaveChanges();

            return RedirectToPage("AllCustomer");
        }
    }
}
