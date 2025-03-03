using System.Linq.Expressions;

namespace WebApiCRUDDay3Demo.Core.Repositories.Interface
{
    //public interface IRepository<T,TKey> where T : class
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        //T GetById(TKey id);
        T GetById(int id);
        //T GetById(long id);
        //T GetById(string id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        int RowCount();
        //Use Include for Eager Loading
        IEnumerable<T> GetAllIncluding(params string[] includes);
    }
}
