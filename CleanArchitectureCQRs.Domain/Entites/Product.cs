using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Domain.Entites;

public class Product
{
    public Guid ProductId { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public int Price { get; set; }
    public string? image {  get; set; }
    public Category Category { get; set; }
    public WishList? WishList { get; set; }
}
