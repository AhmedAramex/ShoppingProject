using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Application.Models;
using CleanArchitectureCQRs.Domain.Abstractions;
using CleanArchitectureCQRs.Domain.Entites;
using CleanArchitectureCQRs.Infrastructure.Context;
using System.Data;

namespace ExternalServices.Sorting;

public class Sorter<T> : Isorting<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IGenericRepository<T> _repo;

    public Sorter(ApplicationDbContext dbContext, IGenericRepository<T> genericRepo)
    {
        _dbContext = dbContext;
        _repo = genericRepo;
    }
    public async Task<IQueryable<Product>> sorting(string sortBy)
    {
        try
        {
            var sorting = new Dictionary<string, Func<IQueryable<Product>, IOrderedQueryable<Product>>>
            {
                {"Name" , p => p.OrderByDescending(p => p.Name) },
                { "Price", products => products.OrderByDescending(p => p.Price) },
                {"Default", products => products.OrderBy(p => p.Id)}
            };

            if (!sorting.TryGetValue(sortBy, out var sortExpression))
            {
                throw new ArgumentException($"Unsupported sort key: {sortBy}", nameof(sortBy));
            }

            IQueryable<Product> query = sortExpression(_dbContext.Products);
            var x = await Task.FromResult(query);
            return x;
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error sorting products: {ex}");
            return Enumerable.Empty<Product>().AsQueryable();
        }
    }

    //public async Task<List<T>> Filtering(FilterBy filterBy, ISpecification<T> spec)
    //{

    //    var query = _repo.GetAllAsyncBySpec(spec);
    //    return await query;
    //    //var BaseQuery = _dbcontect.Products;

    //if (!string.IsNullOrEmpty(filterBy.Name))
    //    BaseQuery.Where(p => p.Name == filterBy.Name);

    //if (filterBy.MaxPrice is not null)
    //    BaseQuery.Where(p => p.Price == filterBy.MaxPrice);

    //var result = BaseQuery.ToList();


    //var Dic = new Dictionary<string, Func<IQueryable<Product>, List<Product>>>()
    //{
    //    { "Name" , Product => Product.Where(p => p.Name == "Name").ToList()}

    //};

    //return null;

    //}

}
