namespace WebApiCRUDDay3Demo.BL.Interface
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        int GetCounter();
    }
}
