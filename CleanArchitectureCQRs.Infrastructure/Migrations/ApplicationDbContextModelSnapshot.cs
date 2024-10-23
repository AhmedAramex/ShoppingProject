﻿// <auto-generated />
using System;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArchitectureCQRs.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2247da39-e270-47fa-be67-9e7593ae1436"),
                            Description = "Devices and gadgets",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("b17958bf-79e3-42c7-ba52-cc03c0951da3"),
                            Description = "Various genres of books",
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("2540a5c5-59a1-41e2-aab4-4e279713b460"),
                            Description = "Apparel for men and women",
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = new Guid("fd1e0505-d4ae-4b57-8360-2e75044c2bcb"),
                            Description = "Household items",
                            Name = "Home & Kitchen"
                        },
                        new
                        {
                            Id = new Guid("c860759c-95ba-47cc-bf76-4116ee4c58cd"),
                            Description = "Sporting goods and equipment",
                            Name = "Sports"
                        },
                        new
                        {
                            Id = new Guid("dd2987de-c77b-407d-8e3e-64c622dcaa74"),
                            Description = "Toys for children of all ages",
                            Name = "Toys"
                        },
                        new
                        {
                            Id = new Guid("7a4fba39-8db6-49fb-a1fa-a813f0321e93"),
                            Description = "Healthcare and beauty products",
                            Name = "Health & Beauty"
                        },
                        new
                        {
                            Id = new Guid("41e737b0-d505-4965-afef-50912cf06ad0"),
                            Description = "Car parts and accessories",
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = new Guid("8fc52087-815c-474a-93cd-7c77770d25c5"),
                            Description = "Instruments and music equipment",
                            Name = "Music"
                        },
                        new
                        {
                            Id = new Guid("c2b405fb-cd94-4c6c-b577-587243d673dc"),
                            Description = "Stationery and office essentials",
                            Name = "Office Supplies"
                        });
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("126028d4-c5a1-4da7-adb9-b841fd7155e9"),
                            CategoryId = new Guid("2247da39-e270-47fa-be67-9e7593ae1436"),
                            Description = "Latest model",
                            Image = "smartphone.jpg",
                            Name = "Smartphone",
                            Price = 699
                        },
                        new
                        {
                            Id = new Guid("eb50f9ec-8d0e-4040-8e9b-f6ace8eb7c4b"),
                            CategoryId = new Guid("2247da39-e270-47fa-be67-9e7593ae1436"),
                            Description = "15-inch display",
                            Image = "laptop.jpg",
                            Name = "Laptop",
                            Price = 999
                        },
                        new
                        {
                            Id = new Guid("6a5b2fa8-7983-4918-80dc-939cf1d5b51a"),
                            CategoryId = new Guid("2247da39-e270-47fa-be67-9e7593ae1436"),
                            Description = "Water-resistant smartwatch",
                            Image = "smartwatch.jpg",
                            Name = "Smartwatch",
                            Price = 199
                        },
                        new
                        {
                            Id = new Guid("81265d34-cc0b-4e71-bdda-fbbd34b64b3d"),
                            CategoryId = new Guid("b17958bf-79e3-42c7-ba52-cc03c0951da3"),
                            Description = "Portable e-book reader",
                            Image = "ebook.jpg",
                            Name = "E-book Reader",
                            Price = 129
                        },
                        new
                        {
                            Id = new Guid("cb3d9eda-8cd4-4989-8a2a-f48f54844133"),
                            CategoryId = new Guid("b17958bf-79e3-42c7-ba52-cc03c0951da3"),
                            Description = "Bestselling novel",
                            Image = "book.jpg",
                            Name = "Fiction Book",
                            Price = 20
                        },
                        new
                        {
                            Id = new Guid("81f0cc1f-f46d-4bfb-8474-074d3a28583e"),
                            CategoryId = new Guid("b17958bf-79e3-42c7-ba52-cc03c0951da3"),
                            Description = "Self-improvement guide",
                            Image = "self_help.jpg",
                            Name = "Self-help Book",
                            Price = 15
                        },
                        new
                        {
                            Id = new Guid("00c288d9-e2b5-489c-933f-4076d7f24978"),
                            CategoryId = new Guid("2540a5c5-59a1-41e2-aab4-4e279713b460"),
                            Description = "Cotton T-shirt",
                            Image = "tshirt.jpg",
                            Name = "T-shirt",
                            Price = 15
                        },
                        new
                        {
                            Id = new Guid("73b2066b-59c7-4680-8397-40a7c629d9ed"),
                            CategoryId = new Guid("2540a5c5-59a1-41e2-aab4-4e279713b460"),
                            Description = "Denim jeans",
                            Image = "jeans.jpg",
                            Name = "Jeans",
                            Price = 45
                        },
                        new
                        {
                            Id = new Guid("7ea8b742-f707-401b-bebd-4fadfac48bac"),
                            CategoryId = new Guid("2540a5c5-59a1-41e2-aab4-4e279713b460"),
                            Description = "Leather jacket",
                            Image = "jacket.jpg",
                            Name = "Jacket",
                            Price = 120
                        },
                        new
                        {
                            Id = new Guid("d73345ca-42db-4fc2-91d0-664847a278ec"),
                            CategoryId = new Guid("fd1e0505-d4ae-4b57-8360-2e75044c2bcb"),
                            Description = "High-speed blender",
                            Image = "blender.jpg",
                            Name = "Blender",
                            Price = 85
                        },
                        new
                        {
                            Id = new Guid("ad737a97-55b4-4453-9e54-7ac56d250387"),
                            CategoryId = new Guid("fd1e0505-d4ae-4b57-8360-2e75044c2bcb"),
                            Description = "Comfortable sofa",
                            Image = "couch.jpg",
                            Name = "Couch",
                            Price = 499
                        },
                        new
                        {
                            Id = new Guid("d251a43a-6006-4280-8103-1d8093c47418"),
                            CategoryId = new Guid("fd1e0505-d4ae-4b57-8360-2e75044c2bcb"),
                            Description = "Automatic coffee machine",
                            Image = "coffee_maker.jpg",
                            Name = "Coffee Maker",
                            Price = 75
                        },
                        new
                        {
                            Id = new Guid("6f9baea4-9716-4dfd-8940-8ca847c0183a"),
                            CategoryId = new Guid("c860759c-95ba-47cc-bf76-4116ee4c58cd"),
                            Description = "Official size basketball",
                            Image = "basketball.jpg",
                            Name = "Basketball",
                            Price = 29
                        },
                        new
                        {
                            Id = new Guid("4c000cd4-a3c3-4e24-bd6b-a64ae804a085"),
                            CategoryId = new Guid("c860759c-95ba-47cc-bf76-4116ee4c58cd"),
                            Description = "Lightweight racket",
                            Image = "racket.jpg",
                            Name = "Tennis Racket",
                            Price = 99
                        },
                        new
                        {
                            Id = new Guid("91909d80-f091-4e76-bd01-d1de304598bb"),
                            CategoryId = new Guid("c860759c-95ba-47cc-bf76-4116ee4c58cd"),
                            Description = "High-performance running shoes",
                            Image = "running_shoes.jpg",
                            Name = "Running Shoes",
                            Price = 60
                        },
                        new
                        {
                            Id = new Guid("138a487b-192e-4927-a779-ce2cf0d14083"),
                            CategoryId = new Guid("dd2987de-c77b-407d-8e3e-64c622dcaa74"),
                            Description = "Popular action figure",
                            Image = "action_figure.jpg",
                            Name = "Action Figure",
                            Price = 25
                        },
                        new
                        {
                            Id = new Guid("ac43dabf-a220-4474-84c3-10b59b0503ec"),
                            CategoryId = new Guid("dd2987de-c77b-407d-8e3e-64c622dcaa74"),
                            Description = "Remote control car",
                            Image = "toy_car.jpg",
                            Name = "Toy Car",
                            Price = 50
                        },
                        new
                        {
                            Id = new Guid("4a2c0dbe-cd1f-4da1-95ba-beaab3de9883"),
                            CategoryId = new Guid("dd2987de-c77b-407d-8e3e-64c622dcaa74"),
                            Description = "Colorful building blocks",
                            Image = "building_blocks.jpg",
                            Name = "Building Blocks",
                            Price = 40
                        },
                        new
                        {
                            Id = new Guid("894e02a1-78cc-4eb4-970c-5430abcd964e"),
                            CategoryId = new Guid("7a4fba39-8db6-49fb-a1fa-a813f0321e93"),
                            Description = "Herbal shampoo",
                            Image = "shampoo.jpg",
                            Name = "Shampoo",
                            Price = 12
                        },
                        new
                        {
                            Id = new Guid("fac6ffea-12cf-4e8f-8bbb-3de06f8cbe0e"),
                            CategoryId = new Guid("7a4fba39-8db6-49fb-a1fa-a813f0321e93"),
                            Description = "Anti-aging cream",
                            Image = "face_cream.jpg",
                            Name = "Face Cream",
                            Price = 35
                        },
                        new
                        {
                            Id = new Guid("30c47023-5b69-4261-b13e-0d91fc140584"),
                            CategoryId = new Guid("7a4fba39-8db6-49fb-a1fa-a813f0321e93"),
                            Description = "Electric toothbrush",
                            Image = "toothbrush.jpg",
                            Name = "Toothbrush",
                            Price = 45
                        },
                        new
                        {
                            Id = new Guid("e54bff2d-3315-4149-b953-9a7d856d1285"),
                            CategoryId = new Guid("41e737b0-d505-4965-afef-50912cf06ad0"),
                            Description = "12V car battery",
                            Image = "car_battery.jpg",
                            Name = "Car Battery",
                            Price = 120
                        },
                        new
                        {
                            Id = new Guid("577dfdb7-8a33-4f68-af7e-538971cd7313"),
                            CategoryId = new Guid("41e737b0-d505-4965-afef-50912cf06ad0"),
                            Description = "Leather seat cover",
                            Image = "seat_cover.jpg",
                            Name = "Car Seat Cover",
                            Price = 60
                        },
                        new
                        {
                            Id = new Guid("4defe845-7bdc-4d3c-99f0-f467eeb24349"),
                            CategoryId = new Guid("41e737b0-d505-4965-afef-50912cf06ad0"),
                            Description = "Portable tire inflator",
                            Image = "tire_inflator.jpg",
                            Name = "Tire Inflator",
                            Price = 35
                        },
                        new
                        {
                            Id = new Guid("038840b3-6033-4e85-84af-bd787f7cbfde"),
                            CategoryId = new Guid("8fc52087-815c-474a-93cd-7c77770d25c5"),
                            Description = "Acoustic guitar",
                            Image = "guitar.jpg",
                            Name = "Guitar",
                            Price = 200
                        },
                        new
                        {
                            Id = new Guid("3afe687b-8303-4246-ac95-ab18ea7c598d"),
                            CategoryId = new Guid("8fc52087-815c-474a-93cd-7c77770d25c5"),
                            Description = "Complete drum kit",
                            Image = "drum_set.jpg",
                            Name = "Drum Set",
                            Price = 550
                        },
                        new
                        {
                            Id = new Guid("d4450736-95da-493f-8234-29db76797330"),
                            CategoryId = new Guid("8fc52087-815c-474a-93cd-7c77770d25c5"),
                            Description = "Digital piano",
                            Image = "piano.jpg",
                            Name = "Piano",
                            Price = 350
                        },
                        new
                        {
                            Id = new Guid("8e7fdbd4-7351-4505-8bda-bbb9283aefb5"),
                            CategoryId = new Guid("c2b405fb-cd94-4c6c-b577-587243d673dc"),
                            Description = "Heavy-duty stapler",
                            Image = "stapler.jpg",
                            Name = "Stapler",
                            Price = 12
                        },
                        new
                        {
                            Id = new Guid("4175e1dc-0d9d-416e-81bb-a7c5e526483d"),
                            CategoryId = new Guid("c2b405fb-cd94-4c6c-b577-587243d673dc"),
                            Description = "Laser printer",
                            Image = "printer.jpg",
                            Name = "Printer",
                            Price = 150
                        },
                        new
                        {
                            Id = new Guid("0b268822-359e-40e6-9723-0ef6af520600"),
                            CategoryId = new Guid("c2b405fb-cd94-4c6c-b577-587243d673dc"),
                            Description = "Ergonomic office chair",
                            Image = "desk_chair.jpg",
                            Name = "Desk Chair",
                            Price = 180
                        });
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Wishlist", b =>
                {
                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UsersId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Wishlists");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Product", b =>
                {
                    b.HasOne("CleanArchitectureCQRs.Domain.Entites.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Wishlist", b =>
                {
                    b.HasOne("CleanArchitectureCQRs.Domain.Entites.Product", "Product")
                        .WithMany("Wishlists")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Product", b =>
                {
                    b.Navigation("Wishlists");
                });
#pragma warning restore 612, 618
        }
    }
}
