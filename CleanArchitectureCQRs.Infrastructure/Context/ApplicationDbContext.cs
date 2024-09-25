using CleanArchitectureCQRs.Domain.Entites;
using CleanArchitectureCQRs.Infrastructure.Seeding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Infrastructure.Context;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) { }


    public DbSet<Users> users { get; set; }
    public DbSet<Product> products { get; set; }
    public DbSet<WishList> wishLists { get; set; }
    public DbSet<Category> categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //product
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasOne(p => p.Category)
            .WithMany(c => c.Products);

            entity.HasOne(p => p.WishList)
            .WithMany(w => w.Products);
        });

        //category 
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(c => c.Category);

        //users
        modelBuilder.Entity<Users>()
            .HasOne(u => u.WishList);
            

        //WishList
        modelBuilder.Entity<WishList>(entity =>
        {
            entity
            .HasMany(p => p.Products)
            .WithOne(w => w.WishList);
        });
    }
}
