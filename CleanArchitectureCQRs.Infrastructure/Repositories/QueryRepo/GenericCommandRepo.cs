using CleanArchitectureCQRs.Application.IReposatories;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Infrastructure.Repositories.QueryRepo;

public class GenericCommandRepo<T> : ICommandGenericRepo<T> where T : class
{
    private readonly ApplicationDbContext _dbContext;

    public GenericCommandRepo(ApplicationDbContext dbContext)
    {
        dbContext = _dbContext;
    }
    public async Task<T> Add(T item)
    => await _dbContext.Set<T>().AddAsync(item);

    public Task<T> Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Task<T> Update(int id)
    {
        throw new NotImplementedException();
    }
}
