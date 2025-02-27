namespace Canbanissimo.Application.Persistence.Contracts;

public interface IGenericRepository<T> where T : class
{
    Task<T> Get(Guid id);
    Task<IReadOnlyList<T>> GetAll();
    Task<IReadOnlyList<T>> Add(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
}