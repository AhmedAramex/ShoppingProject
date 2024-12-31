using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Application.Specification;
using CleanArchitectureCQRs.Domain.Abstractions;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    private readonly ApplicationDbContext _dbContext;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> Add(T item)
    {
        await _dbContext.Set<T>().AddAsync(item);
        return item;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<List<T>> GetAllAsyncBySpec(ISpecification<T> specification)
    {
        try
        {
            var x = await SpecificationEvaluator<T>.GetQueryAsync(_dbContext.Set<T>(), specification).ToListAsync();
            return x;
        }
        catch (Exception ex)
        {
            return null;
        }

    }


    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public void Remove(T entity)
    {
        _dbContext.Remove(entity);
    }

    public void RemoveById(Guid id)
    {
        var entity = new T()
        {
            Id = id
        };
        _dbContext.Remove(entity);
    }

    public async Task<int> SaveAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }

    public void Update(T entity)
    {
        _dbContext.Set<T>().Attach(entity);
        _dbContext.Entry(entity).State = EntityState.Modified;
    }

    public async Task<List<T>> WhereAsync(Expression<Func<T, bool>> predicate) => await _dbContext.Set<T>().Where(predicate).ToListAsync();
}
