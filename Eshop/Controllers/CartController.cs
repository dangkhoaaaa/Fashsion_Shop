using Microsoft.AspNetCore.Mvc;

namespace Eshop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddToCart(int productId)
        {
            return View("Cart");
        }
    }
}
