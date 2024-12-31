using AutoMapper;
using CleanArchitectureCQRs.Application.Enum;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Application.Specification;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;
using System.Linq.Expressions;

namespace CleanArchitectureCQRs.Application.Features.ProductsHandler.Queries;

public record GetProductRequest(string Filterby) : IRequest<List<Product>>;

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
        try
        {

            switch (request.Filterby)
            {

            }
            Expression<Func<Product, bool>> where = x => x.Name == request.Filterby;
            var spec = new ProductWithBrand(where);
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


