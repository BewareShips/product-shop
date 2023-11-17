using Microsoft.EntityFrameworkCore;
using shopBackend.Models;

namespace shopBackend.Data
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Person> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem>OrderItems { get; set; }
        public DbSet<OrderStatus>OrderStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(InitialData.GetCategories());
            modelBuilder.Entity<Product>().HasData(InitialData.GetProducts());
        }


    }

}
