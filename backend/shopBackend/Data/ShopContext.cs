﻿using Microsoft.EntityFrameworkCore;
using shopBackend.Models;

namespace shopBackend.Data
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem>OrderItems { get; set; }
        public DbSet<OrderStatus>OrderStatuses { get; set; }

       

    }
    
}
