using AutoMapper;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Application.Specification;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.ProductsHandler.Queries;

public record GetProductRequest(string SortBy) : IRequest<List<Product>>;

public class GetProductHandler : IRequestHandler<GetProductRequest, List<Product>>
{
    private readonly IGenericRepository<Product> _genericRepo;
    private readonly IMapper _mapper;

    public GetProductHandler(IGenericRepository<Product> genericRepo, IMapper mapper)
    {
        _genericRepo = genericRepo;
        _mapper = mapper;
    }

    public async Task<List<Product>> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {

        //var product = await _genericRepo.GetAllAsync();
        //List<ProductDto> ProductList = new List<ProductDto>();
        var spec = new BaseSpecification<Product>()
        {
            Criteria = x => x.Name == request.SortBy
        };
        var filteration = await _genericRepo.GetAllAsyncBySpec(spec);
        return filteration;

        //foreach (var item in product)
        //{
        //    var productmap = _mapper.Map<ProductDto>(item);
        //    ProductList.Add(productmap);
        //}

        //return x;
    }
}


