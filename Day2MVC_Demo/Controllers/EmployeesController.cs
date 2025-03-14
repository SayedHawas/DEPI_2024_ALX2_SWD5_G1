using Day2MVC_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2MVC_Demo.Controllers
{
    public class EmployeesController : Controller
    {
        public static List<Employee> Employees = new List<Employee>()
        {
             new Employee{ ID = 1 , Name = "Ahmed" , Job = "DR" , Salary = 20000 },
             new Employee{ ID = 2 , Name = "Sayed" , Job = "Eng" , Salary = 15000 },
             new Employee{ ID = 3 , Name = "Amr" , Job = "Developer" , Salary = 25000 },
             new Employee{ ID = 4 , Name = "Tammer" , Job = "teacher" , Salary = 30000 }
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowEmployee(int id)
        {
            var selectEmployee = Employees.FirstOrDefault(e => e.ID == id);

            return View(selectEmployee);
        }

    }
}
