using Day2MVC_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2MVC_Demo.Controllers
{
    public class ValuesController : Controller
    {
        public IActionResult Index()
        {
            //pass data from controllers to View
            //* **********************************
            ////ViewData   mvc 1 ,mvc 2  and above ----> Object  Casting  Box / unbox
            ////Viewbag    Mvc 3 and Above         ----> Dynamic
            ///
            //object obj = 123;  //Box
            //int x = (int)obj;  //Unbox

            //Variables 
            ViewData.Add("name", "Sayed Hawas");
            ViewData["Job"] = "Developer";
            ViewData["number"] = 200;


            ViewBag.Salary = 15000;
            return View();
        }

        public IActionResult ShowData()
        {
            ViewBag.Name = "Sayed Hawas";
            ViewBag.age = 41;
            ViewData["Job"] = "Developer";
            ViewData["Address"] = "Alex";
            ViewData.Add("x", "Welcome in ViewData"); // as  Dictionary(Key,Value)
            return View();
        }
        public ActionResult ShowData2()
        {
            ViewData.Add("FName", "Sayed");
            ViewData["LName"] = "Hawas";
            ViewData["age"] = 41;
            ViewBag.Salary = 10000;
            return View();
        }


        public IActionResult ShowEmployeeData()
        {
            Employee employeeObj = new Employee();
            employeeObj.ID = 1;
            employeeObj.Name = "Osama Elsayed";
            employeeObj.Job = "DR";
            employeeObj.Salary = 30000;

            ViewData["emp"] = employeeObj;
            return View();
        }

        public IActionResult ShowEmployeeData2()
        {
            Employee employeeObj = new Employee();
            employeeObj.ID = 1;
            employeeObj.Name = "Osama Elsayed";
            employeeObj.Job = "DR";
            employeeObj.Salary = 30000;

            //Pass Data As Model 
            return View(employeeObj);
        }
    }
}
