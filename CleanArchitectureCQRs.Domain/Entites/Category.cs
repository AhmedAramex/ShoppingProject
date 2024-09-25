using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Domain.Entites;

public class Category
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string? Description { get; set; }
    public ICollection<Product> Products { get; set; }
   
}
