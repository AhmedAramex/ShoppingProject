using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Domain.Entites;

public class Wishlist : BaseEntity
{
    public Guid UsersId { get; set; }
    public Guid ProductId { get; set; }
    public virtual Product? Product { get; set; }
}

