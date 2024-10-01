using CleanArchitectureCQRs.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureCQRs.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Product> products { get; set; }
    public DbSet<Wishlist> wishLists { get; set; }
    public DbSet<Category> categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //product
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasOne(p => p.Category)
            .WithMany(c => c.Products);

            entity.HasMany(p => p.Wishlist)
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
            .WithMany(w => w.Wishlist)
            .HasForeignKey(p => p.ProductId);

            entity.HasKey(w => new { w.ProductId, w.UsersId });
        });

        // Seed categories
        var categories = new List<Category>
        {
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Electronics", Description = "Devices and gadgets" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Books", Description = "Various genres of books" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Clothing", Description = "Apparel for men and women" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Home & Kitchen", Description = "Household items" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Sports", Description = "Sporting goods and equipment" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Toys", Description = "Toys for children of all ages" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Health & Beauty", Description = "Healthcare and beauty products" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Automotive", Description = "Car parts and accessories" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Music", Description = "Instruments and music equipment" },
            new Category { CategoryId = Guid.NewGuid(), CategoryName = "Office Supplies", Description = "Stationery and office essentials" }
        };

        modelBuilder.Entity<Category>().HasData(categories);

        // Seed products with CategoryId
        var products = new List<Product> { 
            // Electronics
            new Product { ProductId = Guid.NewGuid(), Name = "Smartphone", Description = "Latest model", Price = 699, Image = "smartphone.jpg", CategoryId = categories[0].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Laptop", Description = "15-inch display", Price = 999, Image = "laptop.jpg", CategoryId = categories[0].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Smartwatch", Description = "Water-resistant smartwatch", Price = 199, Image = "smartwatch.jpg", CategoryId = categories[0].CategoryId },
    
            // Books
            new Product { ProductId = Guid.NewGuid(), Name = "E-book Reader", Description = "Portable e-book reader", Price = 129, Image = "ebook.jpg", CategoryId = categories[1].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Fiction Book", Description = "Bestselling novel", Price = 20, Image = "book.jpg", CategoryId = categories[1].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Self-help Book", Description = "Self-improvement guide", Price = 15, Image = "self_help.jpg", CategoryId = categories[1].CategoryId },

            // Clothing
            new Product { ProductId = Guid.NewGuid(), Name = "T-shirt", Description = "Cotton T-shirt", Price = 15, Image = "tshirt.jpg", CategoryId = categories[2].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Jeans", Description = "Denim jeans", Price = 45, Image = "jeans.jpg", CategoryId = categories[2].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Jacket", Description = "Leather jacket", Price = 120, Image = "jacket.jpg", CategoryId = categories[2].CategoryId },

            // Home & Kitchen
            new Product { ProductId = Guid.NewGuid(), Name = "Blender", Description = "High-speed blender", Price = 85, Image = "blender.jpg", CategoryId = categories[3].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Couch", Description = "Comfortable sofa", Price = 499, Image = "couch.jpg", CategoryId = categories[3].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Coffee Maker", Description = "Automatic coffee machine", Price = 75, Image = "coffee_maker.jpg", CategoryId = categories[3].CategoryId },

            // Sports
            new Product { ProductId = Guid.NewGuid(), Name = "Basketball", Description = "Official size basketball", Price = 29, Image = "basketball.jpg", CategoryId = categories[4].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Tennis Racket", Description = "Lightweight racket", Price = 99, Image = "racket.jpg", CategoryId = categories[4].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Running Shoes", Description = "High-performance running shoes", Price = 60, Image = "running_shoes.jpg", CategoryId = categories[4].CategoryId },

            // Toys
            new Product { ProductId = Guid.NewGuid(), Name = "Action Figure", Description = "Popular action figure", Price = 25, Image = "action_figure.jpg", CategoryId = categories[5].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Toy Car", Description = "Remote control car", Price = 50, Image = "toy_car.jpg", CategoryId = categories[5].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Building Blocks", Description = "Colorful building blocks", Price = 40, Image = "building_blocks.jpg", CategoryId = categories[5].CategoryId },

            // Health & Beauty
            new Product { ProductId = Guid.NewGuid(), Name = "Shampoo", Description = "Herbal shampoo", Price = 12, Image = "shampoo.jpg", CategoryId = categories[6].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Face Cream", Description = "Anti-aging cream", Price = 35, Image = "face_cream.jpg", CategoryId = categories[6].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Toothbrush", Description = "Electric toothbrush", Price = 45, Image = "toothbrush.jpg", CategoryId = categories[6].CategoryId },

            // Automotive
            new Product { ProductId = Guid.NewGuid(), Name = "Car Battery", Description = "12V car battery", Price = 120, Image = "car_battery.jpg", CategoryId = categories[7].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Car Seat Cover", Description = "Leather seat cover", Price = 60, Image = "seat_cover.jpg", CategoryId = categories[7].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Tire Inflator", Description = "Portable tire inflator", Price = 35, Image = "tire_inflator.jpg", CategoryId = categories[7].CategoryId },

            // Music
            new Product { ProductId = Guid.NewGuid(), Name = "Guitar", Description = "Acoustic guitar", Price = 200, Image = "guitar.jpg", CategoryId = categories[8].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Drum Set", Description = "Complete drum kit", Price = 550, Image = "drum_set.jpg", CategoryId = categories[8].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Piano", Description = "Digital piano", Price = 350, Image = "piano.jpg", CategoryId = categories[8].CategoryId },

            // Office Supplies
            new Product { ProductId = Guid.NewGuid(), Name = "Stapler", Description = "Heavy-duty stapler", Price = 12, Image = "stapler.jpg", CategoryId = categories[9].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Printer", Description = "Laser printer", Price = 150, Image = "printer.jpg", CategoryId = categories[9].CategoryId },
            new Product { ProductId = Guid.NewGuid(), Name = "Desk Chair", Description = "Ergonomic office chair", Price = 180, Image = "desk_chair.jpg", CategoryId = categories[9].CategoryId }
        };

        modelBuilder.Entity<Product>().HasData(products);
    }
}
