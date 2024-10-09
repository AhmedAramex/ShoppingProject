using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Domain.Dtos;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Products.Queries;

public record GetProductByIdQuery(Guid Id) : IRequest<ProductDto?>;

public class GetProductQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto?>
{
    private readonly IGenericRepository<Product> _productRepositroy;

    public GetProductQueryHandler(IGenericRepository<Product> productRepositroy)
    {
        _productRepositroy = productRepositroy;
    }

    public async Task<ProductDto?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepositroy.GetByIdAsync(request.Id);



        return new ProductDto()
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
        };
    }

}