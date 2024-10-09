using CleanArchitectureCQRs.Application.IReposatories;
using CleanArchitectureCQRs.Domain.Entites;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Infrastructure.Repositories;

public class GenericRepo<T> : IGenericRepo<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;

    public GenericRepo(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<T> Add(T item)
    {
        await _dbContext.Set<T>().AddAsync(item);
        return item;
    }

    public void Remove(Guid id)
    {
        var entity = GetByIdAsync(id);
        _dbContext.Remove(entity);
        _dbContext.SaveChanges();
    }

    public void Update(T entity)
    {
        _dbContext.Set<T>().Attach(entity);
        _dbContext.Entry(entity).State = EntityState.Modified;
        _dbContext.SaveChanges();
    }

    public async Task<List<T>> GetAllAsync()
    => await _dbContext.Set<T>().ToListAsync();

    public async Task<T> GetByIdAsync(Guid id)
    {
        var entity = await _dbContext.Set<T>().FindAsync(id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Entity with id {id} not found.");
        }

        return entity;
    }
}
