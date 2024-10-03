using CleanArchitectureCQRs.Domain.Abstractions;

namespace CleanArchitectureCQRs.Domain.Entites;

public class Wishlist : BaseEntity
{
    public Guid UsersId { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product? Product { get; set; }
}
