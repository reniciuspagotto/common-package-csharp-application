using System.Linq.Expressions;

namespace PackageUtils.RepositoryUtils;

public interface IRepositoryBase<T>
{
    Task Save(T data);
    Task Update(T data);
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(Guid id);
    Task<T> Get(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> predicate = null);
}