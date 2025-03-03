using WebApiCRUDDay3Demo.BL.Interface;
using WebApiCRUDDay3Demo.Core.UnitOfWorks.Interface;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.BL.Implement
{
    public class ServiceDepartment : IServiceDepartment
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceDepartment(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #region CURD
        public void Add(Department entity)
        {
            _unitOfWork.DepartmentRepository.Add(entity);
            _unitOfWork.Complete();
        }
        public void Delete(int id)
        {
            _unitOfWork.DepartmentRepository.Delete(id);
            _unitOfWork.Complete();
        }
        public IEnumerable<Department> GetAll()
        {
            return _unitOfWork.DepartmentRepository.GetAll();
        }
        public Department GetByID(int id)
        {
            return _unitOfWork.DepartmentRepository.GetById(id);
        }
        public int GetCounter()
        {
            return _unitOfWork.DepartmentRepository.RowCount();
        }
        public void Update(Department entity)
        {
            _unitOfWork.DepartmentRepository.Update(entity);
            _unitOfWork.Complete();
        }
        #endregion
        #region Operations
        public IEnumerable<Department> GetDepartmentsWithEmps()
        {
            var departments = _unitOfWork.DepartmentRepository.GetAllIncluding("Employee");
            return departments;
        }
        #endregion
        //Get Manager 
        //Budget Point
        //Logical business 
    }
}
