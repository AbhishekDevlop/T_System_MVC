using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            List<Employee> employees = new List<Employee>() { new Employee {empId=10,empName="Sooraj",empSalary = 122122 }, new Employee { empId = 101, empName = "Dhiraj", empSalary = 782122 } };
            ViewBag.Employees = employees;
            ViewData["Empoyees"] = employees;
            return View();
        }
    }
}
