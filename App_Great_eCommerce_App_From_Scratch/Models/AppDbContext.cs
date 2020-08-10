using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App_Great_eCommerce_App_From_Scratch.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed products
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Rubberised Print T-Shirt",
                Price = 9.99M,
                ImageUrl = @"https://st.depositphotos.com/2251265/4803/i/450/depositphotos_48037605-stock-photo-man-wearing-t-shirt.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Contrast Top TRF",
                Price = 11.99M,
                ImageUrl = @"https://picture-cdn.wheretoget.it/tvrznj-i.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Tied Leather Heeled Sandals",
                Price = 49.95M,
                ImageUrl = @"https://celticandco.global.ssl.fastly.net/usercontent/img/col-12/69602.jpg"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Leather High Heel Sandals With Gathering",
                Price = 39.95M,
                ImageUrl = @"https://cf.shopee.com.my/file/36df2e1d04ca103f16ccefffa9927728"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Pleated Palazzo Trousers TRF",
                Price = 29.95M,
                ImageUrl = @"https://cf.shopee.ph/file/fecc650ca5802d709890a66cc00cfe23"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Skinny Trousers With Belt",
                Price = 19.99M,
                ImageUrl = @"https://emma.bg/images/products/damski-pantalon-faded-black-super-skinny-trousers-1.jpg"
            });

        }
    }
}
