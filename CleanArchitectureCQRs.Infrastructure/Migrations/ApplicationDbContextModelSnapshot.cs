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
                            Id = new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"),
                            Description = "Devices and gadgets",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"),
                            Description = "Various genres of books",
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"),
                            Description = "Apparel for men and women",
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"),
                            Description = "Household items",
                            Name = "Home & Kitchen"
                        },
                        new
                        {
                            Id = new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"),
                            Description = "Sporting goods and equipment",
                            Name = "Sports"
                        },
                        new
                        {
                            Id = new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"),
                            Description = "Toys for children of all ages",
                            Name = "Toys"
                        },
                        new
                        {
                            Id = new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"),
                            Description = "Healthcare and beauty products",
                            Name = "Health & Beauty"
                        },
                        new
                        {
                            Id = new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"),
                            Description = "Car parts and accessories",
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"),
                            Description = "Instruments and music equipment",
                            Name = "Music"
                        },
                        new
                        {
                            Id = new Guid("1b3ae46e-e597-4430-833f-891aff03559a"),
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
                            Id = new Guid("13372628-186f-477f-b585-092db4a7b5db"),
                            CategoryId = new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"),
                            Description = "Latest model",
                            Image = "smartphone.jpg",
                            Name = "Smartphone",
                            Price = 699
                        },
                        new
                        {
                            Id = new Guid("9a29bb2f-6f28-42c6-acc7-32c9d3af89a1"),
                            CategoryId = new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"),
                            Description = "15-inch display",
                            Image = "laptop.jpg",
                            Name = "Laptop",
                            Price = 999
                        },
                        new
                        {
                            Id = new Guid("c615a9aa-5893-4196-9c04-11613edd05ca"),
                            CategoryId = new Guid("d196fdf4-b242-4fd7-b0a8-6d321fded772"),
                            Description = "Water-resistant smartwatch",
                            Image = "smartwatch.jpg",
                            Name = "Smartwatch",
                            Price = 199
                        },
                        new
                        {
                            Id = new Guid("00b3bc64-ac40-4dd3-ba6f-11aa7be81a21"),
                            CategoryId = new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"),
                            Description = "Portable e-book reader",
                            Image = "ebook.jpg",
                            Name = "E-book Reader",
                            Price = 129
                        },
                        new
                        {
                            Id = new Guid("4b14f67e-713b-4b6c-8d75-81ebe6a6fc96"),
                            CategoryId = new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"),
                            Description = "Bestselling novel",
                            Image = "book.jpg",
                            Name = "Fiction Book",
                            Price = 20
                        },
                        new
                        {
                            Id = new Guid("6990e415-0091-466a-b6a7-ccd6d53daef0"),
                            CategoryId = new Guid("21f6e64f-3b2a-4831-8799-9de336dc624c"),
                            Description = "Self-improvement guide",
                            Image = "self_help.jpg",
                            Name = "Self-help Book",
                            Price = 15
                        },
                        new
                        {
                            Id = new Guid("c9c0a336-c621-42db-a585-ce083740d53f"),
                            CategoryId = new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"),
                            Description = "Cotton T-shirt",
                            Image = "tshirt.jpg",
                            Name = "T-shirt",
                            Price = 15
                        },
                        new
                        {
                            Id = new Guid("387f345b-ae4c-47e8-9fd2-99dd53132eb8"),
                            CategoryId = new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"),
                            Description = "Denim jeans",
                            Image = "jeans.jpg",
                            Name = "Jeans",
                            Price = 45
                        },
                        new
                        {
                            Id = new Guid("a95e2efa-bb65-4466-a6de-20bfb8f2eda3"),
                            CategoryId = new Guid("7fdd10ab-cbc5-4be0-af6e-944f5b3ddf00"),
                            Description = "Leather jacket",
                            Image = "jacket.jpg",
                            Name = "Jacket",
                            Price = 120
                        },
                        new
                        {
                            Id = new Guid("13b1b3ca-e63b-47fe-958b-60faf7d3c60a"),
                            CategoryId = new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"),
                            Description = "High-speed blender",
                            Image = "blender.jpg",
                            Name = "Blender",
                            Price = 85
                        },
                        new
                        {
                            Id = new Guid("b2bcaba4-f21c-4d82-960c-c9a03dee10b0"),
                            CategoryId = new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"),
                            Description = "Comfortable sofa",
                            Image = "couch.jpg",
                            Name = "Couch",
                            Price = 499
                        },
                        new
                        {
                            Id = new Guid("20dc7d3e-9c79-44d6-bd57-0f2774077411"),
                            CategoryId = new Guid("70e380b2-4889-4a25-9be8-17d55e1f79a0"),
                            Description = "Automatic coffee machine",
                            Image = "coffee_maker.jpg",
                            Name = "Coffee Maker",
                            Price = 75
                        },
                        new
                        {
                            Id = new Guid("68b985b5-c3a6-4912-b33d-b3ae0789246a"),
                            CategoryId = new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"),
                            Description = "Official size basketball",
                            Image = "basketball.jpg",
                            Name = "Basketball",
                            Price = 29
                        },
                        new
                        {
                            Id = new Guid("01326155-bd05-4923-9e09-6e2be377b63e"),
                            CategoryId = new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"),
                            Description = "Lightweight racket",
                            Image = "racket.jpg",
                            Name = "Tennis Racket",
                            Price = 99
                        },
                        new
                        {
                            Id = new Guid("f0dc8d6f-8614-4dc2-a080-839a43685af2"),
                            CategoryId = new Guid("fc8afc8f-8b2a-4bab-b8ed-3391a982314e"),
                            Description = "High-performance running shoes",
                            Image = "running_shoes.jpg",
                            Name = "Running Shoes",
                            Price = 60
                        },
                        new
                        {
                            Id = new Guid("d5624702-c76c-404f-9403-af521fb38320"),
                            CategoryId = new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"),
                            Description = "Popular action figure",
                            Image = "action_figure.jpg",
                            Name = "Action Figure",
                            Price = 25
                        },
                        new
                        {
                            Id = new Guid("7b362711-746b-4b38-a4fc-2afe1e375df2"),
                            CategoryId = new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"),
                            Description = "Remote control car",
                            Image = "toy_car.jpg",
                            Name = "Toy Car",
                            Price = 50
                        },
                        new
                        {
                            Id = new Guid("98d037aa-0a30-415d-9679-b59f26b3059c"),
                            CategoryId = new Guid("cbe5e340-69d2-4080-bfe0-6cc9ecbb9b6d"),
                            Description = "Colorful building blocks",
                            Image = "building_blocks.jpg",
                            Name = "Building Blocks",
                            Price = 40
                        },
                        new
                        {
                            Id = new Guid("7b203b82-bb8a-4dad-a50a-d7d9f9eebefe"),
                            CategoryId = new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"),
                            Description = "Herbal shampoo",
                            Image = "shampoo.jpg",
                            Name = "Shampoo",
                            Price = 12
                        },
                        new
                        {
                            Id = new Guid("0ade2104-bae6-4305-859c-cfe6659bce22"),
                            CategoryId = new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"),
                            Description = "Anti-aging cream",
                            Image = "face_cream.jpg",
                            Name = "Face Cream",
                            Price = 35
                        },
                        new
                        {
                            Id = new Guid("2efe4ed7-5eab-41ad-a8d7-c6e380afe289"),
                            CategoryId = new Guid("b2f25d71-1386-4cd6-9d2f-fcd4b8fde1c4"),
                            Description = "Electric toothbrush",
                            Image = "toothbrush.jpg",
                            Name = "Toothbrush",
                            Price = 45
                        },
                        new
                        {
                            Id = new Guid("45255879-6ff4-48a2-9ac0-c26b5cf00255"),
                            CategoryId = new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"),
                            Description = "12V car battery",
                            Image = "car_battery.jpg",
                            Name = "Car Battery",
                            Price = 120
                        },
                        new
                        {
                            Id = new Guid("672babad-80c2-4060-9328-fa23c4154baa"),
                            CategoryId = new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"),
                            Description = "Leather seat cover",
                            Image = "seat_cover.jpg",
                            Name = "Car Seat Cover",
                            Price = 60
                        },
                        new
                        {
                            Id = new Guid("2f6e3cf5-1560-4282-8790-90f5d616a8e4"),
                            CategoryId = new Guid("8e63f99a-a27a-4560-a3de-f6a7cfb3e8ec"),
                            Description = "Portable tire inflator",
                            Image = "tire_inflator.jpg",
                            Name = "Tire Inflator",
                            Price = 35
                        },
                        new
                        {
                            Id = new Guid("ce9bc056-4351-4e29-a5c3-01e9b3c05ab2"),
                            CategoryId = new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"),
                            Description = "Acoustic guitar",
                            Image = "guitar.jpg",
                            Name = "Guitar",
                            Price = 200
                        },
                        new
                        {
                            Id = new Guid("c89da56e-9b38-4288-ba2e-36166f866f2f"),
                            CategoryId = new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"),
                            Description = "Complete drum kit",
                            Image = "drum_set.jpg",
                            Name = "Drum Set",
                            Price = 550
                        },
                        new
                        {
                            Id = new Guid("2cf500f0-bca1-43f0-922e-8a4c5ed1cc22"),
                            CategoryId = new Guid("4ead4f84-3df2-4d23-8d18-1ec570f59c1a"),
                            Description = "Digital piano",
                            Image = "piano.jpg",
                            Name = "Piano",
                            Price = 350
                        },
                        new
                        {
                            Id = new Guid("70408125-f494-452d-b14e-252cd83b0ea4"),
                            CategoryId = new Guid("1b3ae46e-e597-4430-833f-891aff03559a"),
                            Description = "Heavy-duty stapler",
                            Image = "stapler.jpg",
                            Name = "Stapler",
                            Price = 12
                        },
                        new
                        {
                            Id = new Guid("b1e9caff-3dbc-4971-a2c9-696adce7e39f"),
                            CategoryId = new Guid("1b3ae46e-e597-4430-833f-891aff03559a"),
                            Description = "Laser printer",
                            Image = "printer.jpg",
                            Name = "Printer",
                            Price = 150
                        },
                        new
                        {
                            Id = new Guid("a34a919d-d004-41a4-bddf-b58fb59c6506"),
                            CategoryId = new Guid("1b3ae46e-e597-4430-833f-891aff03559a"),
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
