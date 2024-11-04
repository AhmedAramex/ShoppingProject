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

    public GetProductHandler(IGenericRepository<Product> genericRepo)
    {
        _genericRepo = genericRepo;
    }

    public async Task<List<ProductDto>> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {
        var product = await _genericRepo.GetAllAsync();
        //if (product is null) throw new Exception("Product Not Found");
        List<ProductDto> ProductList = new List<ProductDto>();
        foreach (var item in product)
        {
            var productDTO = new ProductDto
            {
                Id = request.ProductId,
                Name = request.Name ?? "",
                Description = request.Description,
                Price = request.Price,
            };
            ProductList.Add(productDTO);
        }
        return ProductList;

    }
}


