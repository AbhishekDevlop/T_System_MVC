using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo.Controllers
{
    public class HTMLHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
