using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCRUDDay3Demo.BL.Interface;
using WebApiCRUDDay3Demo.DTOs;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.Controllers
{

    //DTO  Two Way --> Insert , Query 

    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        //private readonly AppDbContext _context;
        //Service
        //private readonly ServiceDepartment _ServiceDepartment;
        private readonly IService<Department> _ServiceDepartment;

        // public DepartmentsController(AppDbContext context)
        public DepartmentsController(IService<Department> serviceDepartment)
        {
            _ServiceDepartment = serviceDepartment;
        }

        // GET: api/Departments
        [HttpGet("GetDepartments")]
        public IActionResult GetDepartments()
        {
            #region My Try Code

            //var department = _context.Departments.ToList();

            //foreach (var item in department)
            //{ 
            //   departments.Add()
            //}


            //var departments = _context.Departments.ToList();
            //List<DepartmentDTO> departmentDto = departments;


            //var department = (from db in _context.Departments
            //                 select new { db.DepartmentId, db.Name, db.Description }).ToList();

            //var x = _context.Departments.Select(x => new  { x.DepartmentId , x.Name, x.Description }).ToList();


            //List<DepartmentDTO> departments = new List<DepartmentDTO>();
            //var mylist = _context.Departments.ToList();
            //foreach (Department item in mylist)
            //{
            //    departments.Add(new DepartmentDTO { DepartmentId = item.DepartmentId, Name = item.Name, Description = item.Description });
            //}

            #endregion

            //var departments = _context.Departments.AsNoTracking().Select(s => new DepartmentDTO { DepartmentId = s.DepartmentId, Name = s.Name, Description = s.Description }).ToList();
            //return Ok(departments);
            var departments = _ServiceDepartment.GetAll();
            return Ok(departments);
        }

        //[HttpGet("GetDepartmentsWithEmployees")]
        //public IActionResult GetDepartmentsWithEmployees()
        //{
        //    //var department = _context.Departments.Include("Employees").ToList();
        //    //return Ok(department);
        //    var departments = _ServiceDepartment.GetDepartmentsWithEmps();
        //    return Ok(departments);
        //}

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public IActionResult GetDepartment(int id)
        {
            // var department = _context.Departments.Find(id);
            var department = _ServiceDepartment.GetByID(id);
            if (department == null)
            {
                return NotFound();
            }
            return Ok(department);
        }

        // PUT: api/Departments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutDepartment(int id, DepartmentDTO departmentDto) // Department department)
        {
            //Logs
            if (id != departmentDto.DepartmentId)
            {
                return BadRequest();
            }
            try
            {
                var SelectDepartment = _ServiceDepartment.GetByID(id);
                SelectDepartment.Name = departmentDto.Name;
                SelectDepartment.Description = departmentDto.Description;
                _ServiceDepartment.Update(SelectDepartment);

                //var SelectDepartment = _context.Departments.Find(id);
                //SelectDepartment.Name = departmentDto.Name;
                //SelectDepartment.Description = departmentDto.Description;
                //_context.Entry(department).State = EntityState.Modified;
                //_context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Departments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult PostDepartment([FromForm] DepartmentDTO department)//(Department department)
        {
            _ServiceDepartment.Add(new Department { Name = department.Name, Description = department.Description });
            // _context.Departments.Add(new Department { Name = department.Name, Description = department.Description });
            //_context.SaveChanges();
            return CreatedAtAction("GetDepartment", new { id = department.DepartmentId }, department);
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDepartment(int id)
        {
            var department = _ServiceDepartment.GetByID(id);
            //var department = _context.Departments.Find(id);
            if (department == null)
            {
                return NotFound();
            }

            _ServiceDepartment.Delete(id);
            //_context.Departments.Remove(department);
            //_context.SaveChanges();
            return NoContent();
        }

        private bool DepartmentExists(int id)
        {
            // return _context.Departments.Any(e => e.DepartmentId == id);
            return _ServiceDepartment.GetAll().Any(e => e.DepartmentId == id);
        }
    }
}
