using Eshop.Data;
using Eshop.Infrastructure;
using Eshop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Components
{
    public class CartWidget : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {

            return View(HttpContext.Session.GetJson<Cart>("cart"));
        }
    }
}
