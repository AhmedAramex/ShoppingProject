using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Application.Specification;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Application.Features.ProductsHandler.Queries;

public record GetProductRequest(string FilterBy, string FilerFor, string OrderBy) : IRequest<List<Product>>;

public class GetProductHandler : IRequestHandler<GetProductRequest, List<Product>>
{
    private readonly IGenericRepository<Product> _genericRepo;

    public GetProductHandler(IGenericRepository<Product> genericRepo)
    {
        _genericRepo = genericRepo;
    }

    public async Task<List<Product>> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var spec = new ProductWithBrand();
            if (!String.IsNullOrEmpty(request.FilerFor))
            {
                if (request.FilterBy == "NAME")
                {
                    Expression<Func<Product, bool>> where = x => x.Name == request.FilerFor;
                    spec = new ProductWithBrand(where);
                }
                else if (request.FilterBy == "CATEGORYNAME")
                {
                    Expression<Func<Product, bool>> where = x => x.Category.Name == request.FilerFor;
                    spec = new ProductWithBrand(where);
                }
            }
            if (!string.IsNullOrEmpty(request.OrderBy))
            {
                case 1:

            }
            var filteration = await _genericRepo.GetAllAsyncBySpec(spec);
            return filteration;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}


