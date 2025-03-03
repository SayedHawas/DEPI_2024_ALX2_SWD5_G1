using WebApiCRUDDay3Demo.BL.Interface;
using WebApiCRUDDay3Demo.Core.UnitOfWorks.Interface;
using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.BL.Implement
{
    public class ServiceCompany : IService<Company>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceCompany(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Company entity)
        {
            _unitOfWork.CompanyRepository.Add(entity);
            _unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            _unitOfWork.CompanyRepository.Delete(id);
            _unitOfWork.Complete();
        }

        public IEnumerable<Company> GetAll()
        {
            return _unitOfWork.CompanyRepository.GetAll();
        }

        public Company GetByID(int id)
        {
            return _unitOfWork.CompanyRepository.GetById(id);
        }

        public int GetCounter()
        {
            return _unitOfWork.CompanyRepository.RowCount();
        }

        public void Update(Company entity)
        {
            _unitOfWork.CompanyRepository.Update(entity);
            _unitOfWork.Complete();
        }
    }
}
