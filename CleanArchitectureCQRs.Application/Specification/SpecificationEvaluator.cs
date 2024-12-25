using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Domain.Abstractions;

namespace CleanArchitectureCQRs.Application.Specification;

public static class SpecificationEvaluator<T> where T : BaseEntity
{
    public static IQueryable<T> GetQueryAsync(IQueryable<T> startQuery, ISpecification<T> baseSpecification)
    {
        var Query = startQuery;
        if (baseSpecification.Criteria is not null)
            Query = Query.Where(baseSpecification.Criteria);


        return Query;
    }
}
