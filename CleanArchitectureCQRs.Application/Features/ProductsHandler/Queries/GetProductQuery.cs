using CleanArchitectureCQRs.Application.Features.ProductsHandler.Dtos;
using CleanArchitectureCQRs.Application.IReposatories;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;
using System.Runtime.CompilerServices;

namespace CleanArchitectureCQRs.Application.Features.ProductsHandler.Queries;

public class GetProductRequest : IRequest<List<ProductDTO>>
{
    public Guid? ProductId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }

}
public class GetProductHandler : IRequestHandler<GetProductRequest, List<ProductDTO>>
{
    private readonly IGenericRepo<Product> _genericRepo;

    public GetProductHandler(IGenericRepo<Product> genericRepo)
    {
        _genericRepo = genericRepo;
    }

    public async Task<List<ProductDTO>> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {
        var product = await _genericRepo.GetAllAsync();
        List<ProductDTO> ProductList = new List<ProductDTO>();
        foreach (var item in product)
        {
            var productDTO = new ProductDTO
            {
                ProductId = request.ProductId,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
            };
            ProductList.Add(productDTO);
        }
        return ProductList;

    }
}


