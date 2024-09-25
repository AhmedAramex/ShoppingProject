using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Domain.Entites;

public class Users
{
    public Guid UsersId { get; set; }
    public string UserName { get; set; }
    public virtual WishList WishList { get; set; }
}
