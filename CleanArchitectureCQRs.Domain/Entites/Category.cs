﻿namespace CleanArchitectureCQRs.Domain.Entites;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}
