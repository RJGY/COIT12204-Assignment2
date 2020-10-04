using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KoalaBeach.Infrastructure;
using KoalaBeach.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Internal;

namespace KoalaBeach.Pages
{
    public class ConfirmModel : PageModel
    {
        /*
        private IStoreRepository repository;
         */

        // Variables
        public Cart Cart { get; set; }
        public Models.Order Order { get; set; }
        public void OnGet()
        {
            
        }

        public ConfirmModel(Cart cartService, Models.Order order)
        { 
            // repository = repo;
            Cart = cartService;
            Order = order;
        }

        public IActionResult OnPostCancel()
        {
            return RedirectToPage("/Cart");
        }

        public IActionResult OnPost()
        {
            return RedirectToPage();
        }
    }
}
