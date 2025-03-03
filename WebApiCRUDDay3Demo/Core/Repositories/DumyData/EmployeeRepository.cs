using System.Linq.Expressions;
using WebApiCRUDDay3Demo.Core.Repositories.Interface;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.Core.Repositories.DumyData
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add(Employee entity)
        {
            _appDbContext.Employees.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> Find(Expression<Func<Employee, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllIncluding(params string[] includes)
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int RowCount()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
