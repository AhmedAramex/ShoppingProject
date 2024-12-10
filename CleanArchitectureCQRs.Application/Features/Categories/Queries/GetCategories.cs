using AutoMapper;
using CleanArchitectureCQRs.Application.Interfaces.Repositories;
using CleanArchitectureCQRs.Domain.Entites;
using MediatR;

namespace CleanArchitectureCQRs.Application.Features.Categories.Queries;

public class GetCategories : IRequest<List<CategoryDto>>
{

}

public class GetCategoriesHandler : IRequestHandler<GetCategories ,List<CategoryDto>>
{
    private readonly IGenericRepository<Category> _genericRepo;
    private readonly IMapper _mapper;

    public GetCategoriesHandler(IGenericRepository<Category> genericRepo, IMapper mapper)
    {
        _genericRepo = genericRepo;
        _mapper = mapper;
    }

    public async Task<List<CategoryDto>> Handle(GetCategories request, CancellationToken cancellationToken)
    {
        var CategoryList = new List<CategoryDto>();
        var Categories = await _genericRepo.GetAllAsync();
        foreach (var category in Categories)
        {
            var CategoryDTO = _mapper.Map<CategoryDto>(category);
            CategoryList.Add(CategoryDTO);
        }

        return CategoryList;
    }
}
