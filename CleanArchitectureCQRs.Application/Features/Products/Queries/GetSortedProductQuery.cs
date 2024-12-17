using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Products.Queries;

public class GetSortedProductQuery
{
    public record ProductSorting : IRequest<IReadOnlyList<ProductDto>>;


    //public class ProductSortingHandler : IRequestHandler<IReadOnlyList<ProductDto>>
    //{
    //    public Task Handle(IReadOnlyList<ProductDto> request, CancellationToken cancellationToken)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
