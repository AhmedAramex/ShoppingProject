using CleanArchitectureCQRs.Application.IReposatories;
using CleanArchitectureCQRs.Infrastructure.Context;
using CleanArchitectureCQRs.Infrastructure.Repositories.QueryRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Infrastructure.Repositories.CommandRepo;

public class GenericCommandRepo<T> : ICommandGenericRepo<T> where T : class
{
    private readonly ApplicationDbContext _dbContext;
    private readonly GeneraicQueryRepo<T> _generaicQueryRepo;

    public GenericCommandRepo(ApplicationDbContext dbContext, GeneraicQueryRepo<T> generaicQueryRepo)
    {
        dbContext = _dbContext;
        generaicQueryRepo = _generaicQueryRepo;
    }
    public async Task<T> Add(T item)
    {
        await _dbContext.Set<T>().AddAsync(item);
        return item;
    }

    public void Remove(int id)
    {
        var entity = _generaicQueryRepo.GetByIdAsync(id);
        _dbContext.Remove(entity);
        _dbContext.SaveChanges();

    }

    public Task<T> Update(int id)
    {
        throw new NotImplementedException();
    }
}
