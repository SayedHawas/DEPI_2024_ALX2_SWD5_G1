using WebApiCRUDDay3Demo.Core.Repositories.Interface;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.Core.UnitOfWorks.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Department> DepartmentRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        int Complete();
    }
}
