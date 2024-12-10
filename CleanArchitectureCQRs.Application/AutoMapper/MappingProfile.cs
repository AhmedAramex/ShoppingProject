using AutoMapper;
using CleanArchitectureCQRs.Application.Features.Categories;
using CleanArchitectureCQRs.Domain.Entites;

namespace CleanArchitectureCQRs.Application.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        //CreateMap<List<Product>, List<ProductDto>>().ReverseMap();
    }

}
