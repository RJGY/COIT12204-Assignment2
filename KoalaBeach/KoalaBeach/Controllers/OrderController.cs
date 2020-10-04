using Microsoft.AspNetCore.Mvc;
using KoalaBeach.Models;
using KoalaBeach.Pages;
using System.Linq;
namespace KoalaBeach.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;

        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }
        public ViewResult Checkout() => View(new Models.Order());

        [HttpPost]
        public IActionResult Checkout(Models.Order order)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();

                repository.SaveOrder(order);
                cart.Clear();

                return RedirectToPage("/Completed", new { orderId = order.OrderID });
            }
            else
            {
                return View();
            }
        }

        public IActionResult Confirm()
        {
            return View(cart);
        }

    }
}
