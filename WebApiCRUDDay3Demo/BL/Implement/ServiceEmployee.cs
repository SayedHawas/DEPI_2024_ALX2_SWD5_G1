using WebApiCRUDDay3Demo.BL.Interface;
using WebApiCRUDDay3Demo.Core.UnitOfWorks.Interface;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.BL.Implement
{
    public class ServiceEmployee : IService<Employee>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceEmployee(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Employee entity)
        {
            _unitOfWork.EmployeeRepository.Add(entity);
            _unitOfWork.Complete();
        }
        public void Delete(int id)
        {
            _unitOfWork.EmployeeRepository.Delete(id);
            _unitOfWork.Complete();
        }
        public IEnumerable<Employee> GetAll()
        {
            return _unitOfWork.EmployeeRepository.GetAll();
        }
        public Employee GetByID(int id)
        {
            return _unitOfWork.EmployeeRepository.GetById(id);
        }
        public int GetCounter()
        {
            return _unitOfWork.EmployeeRepository.RowCount();
        }
        public void Update(Employee entity)
        {
            _unitOfWork.EmployeeRepository.Update(entity);
            _unitOfWork.Complete();
        }
    }
}
