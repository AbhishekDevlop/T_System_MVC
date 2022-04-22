using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_Demo.Controllers
{
    public class PersonController : Controller
    {
       

        public IActionResult PersonalDetails()
        {
            List<string> Option = new List<string>();
            Option.Add("Choose an action");
            Option.Add("Yes");
            Option.Add("No");
            ViewData["Option"] = new SelectList(Option);
            return View();
        }
        [HttpPost]
        public ActionResult PersonalDetails(IFormCollection fc, ICollection<string> hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.options = fc["Option"];
            return View("Details");
        }
    }
}
