using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //CRUD Create, Read (All , By ID ), Update , Delete
        //http://localhost:5082/api/Employees
        //Create Field from AppDbContext Class
        private readonly AppDbContext _appDbContext;
        //DI
        //Link Between AppDbContext Object 
        public EmployeesController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        //[HttpGet]
        //public IEnumerable<Employee> Get()
        //{
        //    //var employees = _appDbContext.Employees.ToList();
        //    //return employees;
        //    return _appDbContext.Employees.ToList();
        //}
        // Read ALL
        [HttpGet]
        public IActionResult Get()
        {
            var employees = _appDbContext.Employees.ToList();
            return Ok(employees);
        }
        //api/employees?Name="ahmed"
        //api/employees/5
        //Read By ID 
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id) // Model Binder (Primitive Route[Parameter Or Query string ] | Complex --> request body  )
        {
            var employee = _appDbContext.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult Create(Employee newEmployee) //Body request
        {
            //Validation Check Model 
            if (ModelState.IsValid)
            {
                _appDbContext.Employees.Add(newEmployee);
                _appDbContext.SaveChanges();
                //return Created(); // 201
                return CreatedAtAction("GetById", new { id = newEmployee.Id }, newEmployee);
            }
            else
            {
                return BadRequest(ModelState); //400
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee newEmployee)
        {
            if (id != newEmployee.Id)
            {
                return BadRequest();
            }
            if (!EmployeeExists(id))
            {
                return NotFound();
            }
            try
            {
                _appDbContext.Entry(newEmployee).State = EntityState.Modified;
                _appDbContext.SaveChanges();
                return Ok(newEmployee);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var employee = _appDbContext.Employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            _appDbContext.Employees.Remove(employee);
            _appDbContext.SaveChanges();
            return NoContent();
        }
        private bool EmployeeExists(int id)
        {
            //var employee = _appDbContext.Employees.Find(id);
            // return employee == null ? false : true;
            return _appDbContext.Employees.Any(e => e.Id == id);
        }
    }

}