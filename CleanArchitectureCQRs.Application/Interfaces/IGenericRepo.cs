using CleanArchitectureCQRs.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Application.IReposatories;

public interface IGenericRepo<T> where T : BaseEntity
{
    void Update(T entity);
    void Remove(Guid id);
    Task<T> Add(T item);
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
}
