using WebApiCRUDDay3Demo.Core.Repositories.Interface;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.Core.UnitOfWorks.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        //Properties Model Repositries
        IRepository<Department> DepartmentRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        IRepository<Company> CompanyRepository { get; }

        //SaveChange 
        int Complete();
    }
}
