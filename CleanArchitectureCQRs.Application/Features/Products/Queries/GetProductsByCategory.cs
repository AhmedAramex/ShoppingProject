using AutoMapper;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Products.Queries;

public record GetProductsByCategory(Guid categoryId) : IRequest<List<ProductDto>>;

public class GetProductsByCategoryHandler : IRequestHandler<GetProductsByCategory, List<ProductDto>>
{
    private readonly IGenericRepository<Product> _repository;
    private readonly IMapper _mapper;

    public GetProductsByCategoryHandler(IGenericRepository<Product> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ProductDto>> Handle(GetProductsByCategory request, CancellationToken cancellationToken)
    {
        var productsByCategory = await _repository.WhereAsync(p => p.CategoryId == request.categoryId);

        if (productsByCategory is null) throw new Exception("No products in this category");
        return _mapper.Map<List<ProductDto>>(productsByCategory);
        //var products = new List<ProductDto>();
        //foreach (var product in productsByCategory)
        //{
        //    products.Add();
        //}
    }
}
