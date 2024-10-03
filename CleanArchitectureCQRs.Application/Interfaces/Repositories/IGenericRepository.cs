using CleanArchitectureCQRs.Domain.Abstractions;

namespace CleanArchitectureCQRs.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Guid id);
    void RemoveById(Guid id);
    Task<T> Add(T item);
    void Update(T entity);
    void Remove(T entity);

    Task<int> SaveAsync();
}
