using Microsoft.AspNetCore.Mvc;

namespace MVCAppDay4Demo.Controllers
{
    public class Employees1Controller : Controller
    {
        public IActionResult Index()
        {
            Employee emp = new Employee();
            emp.Id = 3;
            emp.Name = "Osama";
            emp.Job = "Full Stack Developer";
            emp.Salary = 20000;

            //Pass as View Data 
            ViewData["emp2"] = emp;
            //Pass As View Bag
            ViewBag.emp3 = emp;

            //Pass As Model 
            return View(emp);
        }
    }
}
