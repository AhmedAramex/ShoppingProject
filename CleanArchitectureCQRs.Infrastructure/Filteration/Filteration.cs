using CleanArchitectureCQRs.Application.Models;
using CleanArchitectureCQRs.Domain.Abstractions;
using CleanArchitectureCQRs.Domain.Entites;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Infrastructure.Filteration;

public class Filteration<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _dbcontect;

    public Filteration(ApplicationDbContext dbContext)
    {
        _dbcontect = dbContext;
    }
    public IQueryable<Product> Filtering(FilterBy filterBy, List<string> SearchCreiteria)
    {
        var BaseQuery  = _dbcontect.Products;

        if (!string.IsNullOrEmpty(filterBy.Name))
            BaseQuery.Where(p => p.Name == filterBy.Name);

        if (filterBy.MaxPrice is not null)
            BaseQuery.Where(p => p.Price == filterBy.MaxPrice);

        var result  = BaseQuery.ToList();

        
            var Dic = new Dictionary<string, Func<IQueryable<Product>, List<Product>>>()
        {
            { "Name" , Product => Product.Where(p => p.Name == "Name").ToList()}

        };

        return null;

    }


    //public Expression<Func<T, bool>> DynamicFilteration()
    //{

    //}

    //public  IQueryable<T> Filter<T>(this IQueryable<T> query, bool apply, Expression<Func<T, bool>> predicate)
    //  => apply ? query.Where(predicate) : query;
}
