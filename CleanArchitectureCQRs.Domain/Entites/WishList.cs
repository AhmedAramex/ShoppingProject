using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Domain.Entites;

public class WishList
{
    public Guid Id { get; set; }
    public Guid UsersId { get; set; }
    public ICollection<Product> Products { get; set; }
}

//public class Wishlist
//{
//    public int Id { get; set; }
//    public int UserId { get; set; }
//    public User User { get; set; }
//    public ICollection<Product> Products { get; set; }
//}
