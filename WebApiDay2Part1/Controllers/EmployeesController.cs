using Microsoft.AspNetCore.Mvc;
using WebApiDay2Part1.Models;

namespace WebApiDay2Part1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        public static List<Employee> EmployeesList = new List<Employee>()
        {
          new Employee{ Id = 1 , Name="Ahmed", Job = "Developer" },
          new Employee{ Id = 2 , Name="Tammer", Job = "DR" },
          new Employee{ Id = 3 , Name="Yasser", Job = "Eng" },
        };
        [HttpGet]
        public IEnumerable<Employee> Employee()
        {
            return EmployeesList;
        }

        [HttpGet("{id}")]

        public Employee GetById(int id)
        {
            var employee = EmployeesList.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return new Employee() { Name = "Not Found ..." };
            return employee;
        }


        [HttpPost]
        public void Create(Employee newEmployee)
        {
            EmployeesList.Add(newEmployee);

        }
        [HttpPut]
        public void Update(Employee newEmployee)
        {
            var employee = EmployeesList.FirstOrDefault(e => e.Id == newEmployee.Id);
            if (employee != null)
            {
                employee.Name = newEmployee.Name;
                employee.Job = newEmployee.Job;
            }
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var employee = EmployeesList.FirstOrDefault(e => e.Id == id);

            if (employee != null)
                EmployeesList.Remove(employee);

        }


    }
}
