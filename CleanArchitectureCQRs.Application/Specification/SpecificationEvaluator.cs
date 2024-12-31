using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitectureCQRs.Application.Specification;

public static class SpecificationEvaluator<T> where T : BaseEntity
{
    public static IQueryable<T> GetQueryAsync(IQueryable<T> startQuery, ISpecification<T> baseSpecification)
    {
        var Query = startQuery;

        if (baseSpecification.Includes is not null)
            Query = baseSpecification.Includes.Aggregate(Query, (cuurentQuerey, IncludeExpression) => cuurentQuerey.Include(IncludeExpression));

        if (baseSpecification.Criteria is not null)
            Query = Query.Where(baseSpecification.Criteria);

        return Query;
    }
}
