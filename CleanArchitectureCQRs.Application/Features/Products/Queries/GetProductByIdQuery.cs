using AutoMapper;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Products.Queries;

public record GetProductByIdQuery(Guid Id) : IRequest<ProductDto?>;

public class GetProductQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto?>
{
    private readonly IGenericRepository<Product> _productRepositroy;
    private readonly IMapper _mapper;

    public GetProductQueryHandler(IGenericRepository<Product> productRepositroy, IMapper mapper)
    {
        _productRepositroy = productRepositroy;
        _mapper = mapper;
    }

    public async Task<ProductDto?> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepositroy.GetByIdAsync(request.Id);
        if (product == null)
        {
            return null;
        }

        var productDto = _mapper.Map<ProductDto>(product);
        return productDto;
    }
}