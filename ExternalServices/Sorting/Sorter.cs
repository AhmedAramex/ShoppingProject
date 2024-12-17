using CleanArchitectureCQRs.Domain.Entites;
using CleanArchitectureCQRs.Infrastructure.Context;
using System.Data;

namespace ExternalServices.Sorting;

public class Sorter
{
    private readonly ApplicationDbContext _dbContext;

    public Sorter(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<IQueryable<Product>> sorting(string sortBy)
    {
        try
        {
            var sorting = new Dictionary<string, Func<IQueryable<Product>, IOrderedQueryable<Product>>>
            {
                {"Name" , p => p.OrderByDescending(p => p.Name) },
                { "Price", products => products.OrderByDescending(p => p.Price) }
            };

            if (!sorting.TryGetValue(sortBy, out var sortExpression))
            {
                throw new ArgumentException($"Unsupported sort key: {sortBy}", nameof(sortBy));
            }

            IQueryable<Product> query = sortExpression(_dbContext.Products);
            return await Task.FromResult(query);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error sorting products: {ex}");
            return Enumerable.Empty<Product>().AsQueryable();
        }
    }

}
