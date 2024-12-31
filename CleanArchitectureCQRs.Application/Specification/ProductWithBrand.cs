using CleanArchitectureCQRs.Domain.Entites;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Application.Specification;

public class ProductWithBrand : BaseSpecification<Product>
{
    public ProductWithBrand() : base()
    {
        Includes.Add(p => p.Category);
    }

    public ProductWithBrand(Expression<Func<Product, bool>> whereExpression) : base(whereExpression)
    {
        Includes.Add(p => p.Category);
    }

}
