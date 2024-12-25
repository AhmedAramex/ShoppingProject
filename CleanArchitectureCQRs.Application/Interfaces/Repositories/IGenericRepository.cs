using CleanArchitectureCQRs.Domain.Abstractions;
using CleanArchitectureCQRs.Domain.Entites;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Guid id);
    void RemoveById(Guid id);
    Task<T> Add(T item);
    void Update(T entity);
    void Remove(T entity);

    Task<List<T>> GetAllAsyncBySpec(ISpecification<T> spec);
    Task<int> SaveAsync();
    Task<List<T>> WhereAsync(Expression<Func<T, bool>> predicate);
}
