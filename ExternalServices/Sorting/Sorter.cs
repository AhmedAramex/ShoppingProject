using CleanArchitectureCQRs.Domain.Entites;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace ExternalServices.Sorting;

public class Sorter
{
    private readonly ApplicationDbContext _dbContext;

    public Sorter(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public string sorting(string sortBy)
    {
        IQueryable<Product> query = null;


        switch (sortBy)
        {
            case "Name":
                query = _dbContext.Products.OrderBy(x => x.Name);
                break;
            case "Price":
                query = _dbContext.Products.OrderBy(x => x.Price);
                break;
        }
        return string.Empty;
    }


}
