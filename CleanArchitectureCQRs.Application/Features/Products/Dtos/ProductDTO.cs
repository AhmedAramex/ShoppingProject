using CleanArchitectureCQRs.Domain.Entites;

namespace CleanArchitectureCQRs.Application.Features.Products.Dtos;

public class ProductDTO
{
    public Guid? ProductId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? Image { get; set; }
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}
