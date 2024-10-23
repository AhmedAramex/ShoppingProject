using AutoMapper;
using CleanArchitectureCQRs.Domain.Entites;

namespace CleanArchitectureCQRs.Application.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        //CreateMap<List<Product>, List<ProductDto>>().ReverseMap();
    }

}
