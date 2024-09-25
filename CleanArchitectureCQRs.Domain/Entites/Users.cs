namespace CleanArchitectureCQRs.Domain.Entites;

public class Users
{
    public Guid ID { get; set; }
    public string UserName { get; set; }

    public virtual Wishlist WishList { get; set; }
}
