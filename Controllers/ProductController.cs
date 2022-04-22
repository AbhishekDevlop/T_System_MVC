using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Addnew()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            List<Product> products = new List<Product>() { new Product { Id = 1, Name = "KeyBoard", Price = 21212 }, new Product { Id = 2, Name = "Watch", Price = 788212 } };
            ViewBag.Products = products;
            ViewData["Products"] = products;
            return View();
        }
    }
}
