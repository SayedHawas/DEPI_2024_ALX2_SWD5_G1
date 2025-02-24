using System.Linq.Expressions;

namespace WebApiCRUDDay3Demo.Core.Repositories.Interface
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        int RowCount();
        //Use Include for Eager Loading
        IEnumerable<T> GetAllIncluding(params string[] includes);
    }
}
