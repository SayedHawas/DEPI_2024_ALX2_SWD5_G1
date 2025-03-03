using WebApiCRUDDay3Demo.Core.Repositories.Implementing;
using WebApiCRUDDay3Demo.Core.Repositories.Interface;
using WebApiCRUDDay3Demo.Core.UnitOfWorks.Interface;
using WebApiCRUDDay3Demo.Models;
namespace WebApiCRUDDay3Demo.Core.UnitOfWorks.Implementing
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;


        public IRepository<Department> DepartmentRepository { get; }
        public IRepository<Employee> EmployeeRepository { get; }
        public IRepository<Company> CompanyRepository { get; }


        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            EmployeeRepository = new Repository<Employee>(_context);
            CompanyRepository = new Repository<Company>(_context);
            DepartmentRepository = new Repository<Department>(_context);
        }
        public int Complete()
        {
            //Log 
            //Logs File Tables (Information)
            var rows = _context.SaveChanges();
            _context.ChangeTracker.Clear();//.State = EntityState.Detached;
            return rows;
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
