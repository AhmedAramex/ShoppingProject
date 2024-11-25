using CleanArchitectureCQRs.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureCQRs.Infrastructure.Context;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Wishlist> Wishlists { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //product
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasOne(p => p.Category)
            .WithMany(c => c.Products);

            entity.HasMany(p => p.Wishlists)
            .WithOne(w => w.Product);
        });

        //category 
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(c => c.Category);

        //WishList
        modelBuilder.Entity<Wishlist>(entity =>
        {
            entity
            .HasOne(p => p.Product)
            .WithMany(w => w.Wishlists)
            .HasForeignKey(p => p.ProductId);

            entity.HasKey(w => new { w.UsersId, w.ProductId });
        });

    }

}
