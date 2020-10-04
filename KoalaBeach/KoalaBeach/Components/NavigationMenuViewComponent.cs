using Microsoft.AspNetCore.Mvc;
using System.Linq;
using KoalaBeach.Models;

namespace KoalaBeach.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        
        public IViewComponentResult Invoke()
        {
            
            ViewBag.SelectedCategory = RouteData?.Values["category"]; // shirts, caps, shoes etc
            string type = RouteData?.Values["type"].ToString(); // men, women, sale, both

            return View(repository.Products
               //.Where(x => (x.SubCategory == type || (type == "Sale" && x.Sale == true)))
               .Where(x => x.SubCategory == type || x.SubCategory == "Both" && ((type == "Sale" && x.Sale == true) || (type != "Sale" && x.Sale == false)) || (type == "Sale" && x.Sale == true))
               .Select(x => x.Category)
               .Distinct()
               .OrderBy(x => x));
        }
        
    }
}
