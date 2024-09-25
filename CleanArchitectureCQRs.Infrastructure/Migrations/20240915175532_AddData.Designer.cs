﻿// <auto-generated />
using System;
using CleanArchitectureCQRs.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CleanArchitectureCQRs.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240915175532_AddData")]
    partial class AddData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<Guid?>("WishListId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WishListId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Users", b =>
                {
                    b.Property<Guid>("UsersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsersId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.WishList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsersId")
                        .IsUnique();

                    b.ToTable("wishLists");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Product", b =>
                {
                    b.HasOne("CleanArchitectureCQRs.Domain.Entites.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CleanArchitectureCQRs.Domain.Entites.WishList", "WishList")
                        .WithMany("Products")
                        .HasForeignKey("WishListId");

                    b.Navigation("Category");

                    b.Navigation("WishList");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.WishList", b =>
                {
                    b.HasOne("CleanArchitectureCQRs.Domain.Entites.Users", null)
                        .WithOne("WishList")
                        .HasForeignKey("CleanArchitectureCQRs.Domain.Entites.WishList", "UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.Users", b =>
                {
                    b.Navigation("WishList")
                        .IsRequired();
                });

            modelBuilder.Entity("CleanArchitectureCQRs.Domain.Entites.WishList", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
