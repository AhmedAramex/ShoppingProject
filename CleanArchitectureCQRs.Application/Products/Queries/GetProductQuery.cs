using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Domain.Dtos;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;

namespace CleanArchitectureCQRs.Application.Products.Queries;

public record GetProductQuery(Guid Id) : IRequest<ProductDto?>;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductDto?>
{
    private readonly IGenericRepository<Product> _productRepositroy;

    public GetProductQueryHandler(IGenericRepository<Product> productRepositroy)
    {
        _productRepositroy = productRepositroy;
    }

    public async Task<ProductDto?> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepositroy.GetByIdAsync(request.Id);

        if (product is null) throw new Exception("Product Not Found");

        return new ProductDto()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
        };
    }

}