using AutoMapper;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.ProductsHandler.Queries;

public class GetProductRequest : IRequest<List<ProductDto>>
{
    public Guid? ProductId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }

}
public class GetProductHandler : IRequestHandler<GetProductRequest, List<ProductDto>>
{
    private readonly IGenericRepository<Product> _genericRepo;
    private readonly IMapper _mapper;

    public GetProductHandler(IGenericRepository<Product> genericRepo, IMapper mapper)
    {
        _genericRepo = genericRepo;
        _mapper = mapper;
    }

    public async Task<List<ProductDto>> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {
        var product = await _genericRepo.GetAllAsync();
        List<ProductDto> ProductList = new List<ProductDto>();
        foreach (var item in product)
        {
           var productmap = _mapper.Map<ProductDto>(item);
            ProductList.Add(productmap);
        }
        return ProductList;
    }
}


