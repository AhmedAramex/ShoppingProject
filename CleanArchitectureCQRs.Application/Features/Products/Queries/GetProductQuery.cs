using AutoMapper;
using CleanArchitectureCQRs.Application.Interfaces;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;

namespace CleanArchitectureCQRs.Application.Features.ProductsHandler.Queries;

public record GetProductRequest(string SortBy) : IRequest<IQueryable<Product>>;

public class GetProductHandler : IRequestHandler<GetProductRequest, IQueryable<Product>>
{
    private readonly IGenericRepository<Product> _genericRepo;
    private readonly IMapper _mapper;
    private readonly Isorting _sorting;

    public GetProductHandler(IGenericRepository<Product> genericRepo, IMapper mapper, Isorting sorting)
    {
        _genericRepo = genericRepo;
        _mapper = mapper;
        _sorting = sorting;
    }

    public async Task<IQueryable<Product>> Handle(GetProductRequest request, CancellationToken cancellationToken)
    {

        //var product = await _genericRepo.GetAllAsync();
        //List<ProductDto> ProductList = new List<ProductDto>();

        if (!request.SortBy.IsNullOrEmpty())
            return await _sorting.sorting(request.SortBy);
        else
            return null;

        //foreach (var item in product)
        //{
        //    var productmap = _mapper.Map<ProductDto>(item);
        //    ProductList.Add(productmap);
        //}

        //return x;
    }

}


