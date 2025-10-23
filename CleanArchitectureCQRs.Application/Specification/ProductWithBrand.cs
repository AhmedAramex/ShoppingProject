using CleanArchitectureCQRs.Domain.Entites;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Application.Specification;

public class ProductWithBrand : BaseSpecification<Product>
{
    public ProductWithBrand(string Sort) : base()
    {
        Includes.Add(p => p.Category);
        if (!string.IsNullOrEmpty(Sort))
        {
            switch (Sort)
            {
                case "Price":
                    OrderbyASC(P => P.Price);
                    break;
                case "PriceDESC":
                    OrderbyDESC(P => P.Price);
                    break;
            }
        }
    }

    public ProductWithBrand(Expression<Func<Product, bool>> whereExpression) : base(whereExpression)
    {
        Includes.Add(p => p.Category);
    }

}
