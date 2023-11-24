﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shopBackend.Data;

#nullable disable

namespace shopBackend.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20240522213812_AddLoginUserModel")]
    partial class AddLoginUserModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("shopBackend.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Biscuits"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cakes"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dairy"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Snacks"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Bakery"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Meat"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Seafood"
                        });
                });

            modelBuilder.Entity("shopBackend.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("PersonId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("shopBackend.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("shopBackend.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StatusName")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("shopBackend.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("shopBackend.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Delicious Ukrainian cookies",
                            Name = "Cookies 'Maria'",
                            Price = 1.50m,
                            StockQuantity = 100,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Traditional Kyiv cake",
                            Name = "Kyiv Cake",
                            Price = 5.00m,
                            StockQuantity = 50,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Fresh tomatoes",
                            Name = "Tomatoes",
                            Price = 2.50m,
                            StockQuantity = 200,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Fresh cucumbers",
                            Name = "Cucumbers",
                            Price = 2.00m,
                            StockQuantity = 150,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Description = "Fresh apples",
                            Name = "Apples",
                            Price = 1.80m,
                            StockQuantity = 250,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            Description = "Fresh bananas",
                            Name = "Bananas",
                            Price = 1.50m,
                            StockQuantity = 180,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 5,
                            Description = "Fresh milk",
                            Name = "Milk",
                            Price = 1.00m,
                            StockQuantity = 200,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            Description = "Delicious cheese",
                            Name = "Cheese",
                            Price = 8.00m,
                            StockQuantity = 100,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 6,
                            Description = "Freshly squeezed orange juice",
                            Name = "Orange Juice",
                            Price = 3.00m,
                            StockQuantity = 150,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 6,
                            Description = "Premium coffee beans",
                            Name = "Coffee",
                            Price = 10.00m,
                            StockQuantity = 75,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 7,
                            Description = "Delicious chocolate bar",
                            Name = "Chocolate Bar",
                            Price = 2.00m,
                            StockQuantity = 300,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 8,
                            Description = "Freshly baked croissant",
                            Name = "Croissant",
                            Price = 1.50m,
                            StockQuantity = 120,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 8,
                            Description = "Fresh bread",
                            Name = "Bread",
                            Price = 1.20m,
                            StockQuantity = 250,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 9,
                            Description = "Fresh chicken breast",
                            Name = "Chicken Breast",
                            Price = 6.00m,
                            StockQuantity = 100,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 10,
                            Description = "Fresh salmon fillet",
                            Name = "Salmon Fillet",
                            Price = 15.00m,
                            StockQuantity = 80,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Description = "Fresh potatoes",
                            Name = "Potatoes",
                            Price = 1.00m,
                            StockQuantity = 500,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Description = "Fresh carrots",
                            Name = "Carrots",
                            Price = 0.80m,
                            StockQuantity = 400,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "Fresh onions",
                            Name = "Onions",
                            Price = 0.70m,
                            StockQuantity = 350,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            Description = "Fresh garlic",
                            Name = "Garlic",
                            Price = 3.00m,
                            StockQuantity = 100,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Description = "Fresh bell peppers",
                            Name = "Peppers",
                            Price = 2.50m,
                            StockQuantity = 200,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            Description = "Fresh zucchini",
                            Name = "Zucchini",
                            Price = 1.80m,
                            StockQuantity = 150,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Fresh strawberries",
                            Name = "Strawberries",
                            Price = 4.00m,
                            StockQuantity = 100,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Fresh blueberries",
                            Name = "Blueberries",
                            Price = 5.00m,
                            StockQuantity = 80,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 4,
                            Description = "Fresh raspberries",
                            Name = "Raspberries",
                            Price = 5.50m,
                            StockQuantity = 90,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 4,
                            Description = "Fresh pineapple",
                            Name = "Pineapple",
                            Price = 3.50m,
                            StockQuantity = 60,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 4,
                            Description = "Fresh watermelon",
                            Name = "Watermelon",
                            Price = 2.50m,
                            StockQuantity = 70,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 4,
                            Description = "Fresh grapes",
                            Name = "Grapes",
                            Price = 3.00m,
                            StockQuantity = 100,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 4,
                            Description = "Fresh peaches",
                            Name = "Peaches",
                            Price = 2.80m,
                            StockQuantity = 80,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 4,
                            Description = "Fresh plums",
                            Name = "Plums",
                            Price = 2.50m,
                            StockQuantity = 100,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 4,
                            Description = "Fresh cherries",
                            Name = "Cherries",
                            Price = 3.50m,
                            StockQuantity = 70,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 5,
                            Description = "Fresh yogurt",
                            Name = "Yogurt",
                            Price = 0.80m,
                            StockQuantity = 150,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 5,
                            Description = "Fresh butter",
                            Name = "Butter",
                            Price = 2.50m,
                            StockQuantity = 120,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 5,
                            Description = "Fresh cream",
                            Name = "Cream",
                            Price = 1.20m,
                            StockQuantity = 100,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 6,
                            Description = "Refreshing lemonade",
                            Name = "Lemonade",
                            Price = 1.00m,
                            StockQuantity = 200,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 6,
                            Description = "Premium tea leaves",
                            Name = "Tea",
                            Price = 5.00m,
                            StockQuantity = 150,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 36,
                            CategoryId = 7,
                            Description = "Crispy potato chips",
                            Name = "Potato Chips",
                            Price = 1.50m,
                            StockQuantity = 300,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 37,
                            CategoryId = 7,
                            Description = "Salty pretzels",
                            Name = "Pretzels",
                            Price = 1.20m,
                            StockQuantity = 250,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 38,
                            CategoryId = 8,
                            Description = "Sweet donut",
                            Name = "Donut",
                            Price = 1.00m,
                            StockQuantity = 150,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 39,
                            CategoryId = 8,
                            Description = "Fresh bagel",
                            Name = "Bagel",
                            Price = 1.50m,
                            StockQuantity = 200,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 40,
                            CategoryId = 8,
                            Description = "French baguette",
                            Name = "Baguette",
                            Price = 1.80m,
                            StockQuantity = 150,
                            UnitType = 0
                        },
                        new
                        {
                            Id = 41,
                            CategoryId = 9,
                            Description = "Fresh pork chops",
                            Name = "Pork Chops",
                            Price = 5.00m,
                            StockQuantity = 90,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 42,
                            CategoryId = 9,
                            Description = "Juicy beef steak",
                            Name = "Beef Steak",
                            Price = 10.00m,
                            StockQuantity = 70,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 43,
                            CategoryId = 9,
                            Description = "Fresh turkey breast",
                            Name = "Turkey Breast",
                            Price = 7.00m,
                            StockQuantity = 100,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 44,
                            CategoryId = 10,
                            Description = "Fresh shrimps",
                            Name = "Shrimps",
                            Price = 12.00m,
                            StockQuantity = 60,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 45,
                            CategoryId = 10,
                            Description = "Fresh salmon",
                            Name = "Salmon",
                            Price = 15.00m,
                            StockQuantity = 80,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 46,
                            CategoryId = 10,
                            Description = "Fresh mackerel",
                            Name = "Mackerel",
                            Price = 6.00m,
                            StockQuantity = 70,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 47,
                            CategoryId = 10,
                            Description = "Fresh haddock",
                            Name = "Haddock",
                            Price = 8.00m,
                            StockQuantity = 60,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 48,
                            CategoryId = 10,
                            Description = "Fresh oysters",
                            Name = "Oysters",
                            Price = 20.00m,
                            StockQuantity = 50,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 49,
                            CategoryId = 10,
                            Description = "Fresh mussels",
                            Name = "Mussels",
                            Price = 10.00m,
                            StockQuantity = 100,
                            UnitType = 1
                        },
                        new
                        {
                            Id = 50,
                            CategoryId = 10,
                            Description = "Fresh scallops",
                            Name = "Scallops",
                            Price = 25.00m,
                            StockQuantity = 40,
                            UnitType = 1
                        });
                });

            modelBuilder.Entity("shopBackend.Models.Order", b =>
                {
                    b.HasOne("shopBackend.Models.OrderStatus", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shopBackend.Models.Person", "Person")
                        .WithMany("Orders")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("shopBackend.Models.OrderItem", b =>
                {
                    b.HasOne("shopBackend.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("shopBackend.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("shopBackend.Models.Product", b =>
                {
                    b.HasOne("shopBackend.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("shopBackend.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("shopBackend.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("shopBackend.Models.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("shopBackend.Models.Person", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("shopBackend.Models.Product", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
