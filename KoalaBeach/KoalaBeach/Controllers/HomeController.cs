using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KoalaBeach.Models;
using KoalaBeach.Models.ViewModels;

namespace KoalaBeach.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index()
        {
            return View();
        }
        
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult Register()
        {
            return View();
        }

        public ViewResult RegistrationForm()
        {
            return View();
        }

        public ViewResult Cart()
        {
            return View();
        }

        [Route("/Catalog/{type}")]
        [Route("/Catalog/{type}/{category}")]
        public ViewResult Catalog(String type, string category)
        {
            ViewBag.Type = type;            // men, women, sale, both
            ViewBag.Category = category;    // shirts, caps, shoes etc

            IEnumerable<Product> products = repository.Products
                // Sir this is the product of a large amount of trial and error, it works so im not going to touch it even though it is digusing. sorry!
                .Where(p => p.SubCategory == type || p.SubCategory == "Both" && ((type == "Sale" && p.Sale == true) || (type != "Sale" && p.Sale == false)) || (type == "Sale" && p.Sale == true))
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductID);

            return View(products);
        }
        public ViewResult Contact()
        {
            return View();
        }
    }
}
