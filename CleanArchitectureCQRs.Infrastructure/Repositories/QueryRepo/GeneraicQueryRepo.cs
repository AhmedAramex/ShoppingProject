using CleanArchitectureCQRs.Application.IReposatories;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Infrastructure.Repositories.QueryRepo;

public class GeneraicQueryRepo<T> : IQueryGenericRepo<T> where T : class
{
    private readonly ApplicationDbContext _dbContext;

    public GeneraicQueryRepo(ApplicationDbContext dbContext)
    {
        dbContext = _dbContext;
    }

    public async Task<List<T>> GetAllAsync()
    => await _dbContext.Set<T>().ToListAsync();

    public async Task<T> GetByIdAsync(int id)
    {
        var entity = await _dbContext.Set<T>().FindAsync(id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Entity with id {id} not found.");
        }

        return entity;
    }

    //public async Task<T> GetByIdWithIncludesAsync(int id)
    //{
    //    var entitybyId = await _dbContext.Set<T>().FindAsync(id);
    //    var entity = entitybyId.Include(id);
    //    if (entity == null)
    //    {
    //        throw new KeyNotFoundException($"Entity with id {id} not found.");
    //    }

    //    return entity;
    //}
}
