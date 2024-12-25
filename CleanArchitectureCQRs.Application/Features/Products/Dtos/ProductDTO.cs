using CleanArchitectureCQRs.Application.Interfaces;

namespace CleanArchitectureCQRs.Application.Features.Products.Dtos;

public class ProductDto
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? Image { get; set; }
    public Guid? CategoryId { get; set; }
    public string? SortBy { get; set; }
}
