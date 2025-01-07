using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureCQRs.Application.Specification;

public static class SpecificationEvaluator<T> where T : BaseEntity
{
    public static IQueryable<T> GetQueryAsync(IQueryable<T> startQuery, ISpecification<T> baseSpecification)
    {
        var Query = startQuery;

        Query = baseSpecification.Includes.Aggregate(Query, (cuurentQuerey, IncludeExpression) => cuurentQuerey.Include(IncludeExpression));

        if (baseSpecification.Criteria is not null)
            Query = Query.Where(baseSpecification.Criteria);

        if (baseSpecification.OrderbyAsc is not null)
            Query.OrderBy(baseSpecification.OrderbyAsc);

        if (baseSpecification.OrderbyDesc is not null)
            Query.OrderByDescending(baseSpecification.OrderbyDesc);

        return Query;
    }
}
