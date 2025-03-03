using WebApiCRUDDay3Demo.Models;

namespace WebApiCRUDDay3Demo.BL.Interface
{
    public interface IServiceDepartment : IService<Department>
    {
        //CURD
        IEnumerable<Department> GetAll();
        Department GetByID(int id);
        void Add(Department entity);
        void Update(Department entity);
        void Delete(int id);
        int GetCounter();

    }
}
