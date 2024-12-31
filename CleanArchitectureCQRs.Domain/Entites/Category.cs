﻿using CleanArchitectureCQRs.Domain.Abstractions;

namespace CleanArchitectureCQRs.Domain.Entites;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
}
