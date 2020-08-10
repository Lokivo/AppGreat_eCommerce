using App_Great_eCommerce_App_From_Scratch.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Great_eCommerce_App_From_Scratch.Models
{
    public class MockProductRepository : IProductRepository
    {
        public IEnumerable<Product> AllProducts => new List<Product>
        {
            new Product{ Id = 1, Name = "Rubberised Print T-Shirt", Price = 9.99M, ImageUrl = @"https://st.depositphotos.com/2251265/4803/i/450/depositphotos_48037605-stock-photo-man-wearing-t-shirt.jpg" },
            new Product{ Id = 2, Name = "Contrast Top TRF", Price = 11.99M, ImageUrl = @"https://picture-cdn.wheretoget.it/tvrznj-i.jpg" },
            new Product{ Id = 3, Name = "Tied Leather Heeled Sandals", Price = 49.95M, ImageUrl = @"https://celticandco.global.ssl.fastly.net/usercontent/img/col-12/69602.jpg" },
            new Product{ Id = 4, Name = "Leather High Heel Sandals With Gathering", Price = 39.95M, ImageUrl = @"https://cf.shopee.com.my/file/36df2e1d04ca103f16ccefffa9927728" },
            new Product{ Id = 5, Name = "Pleated Palazzo Trousers TRF", Price = 29.95M, ImageUrl = @"https://cf.shopee.ph/file/fecc650ca5802d709890a66cc00cfe23" },
            new Product{ Id = 6, Name = "Skinny Trousers With Belt", Price = 19.99M, ImageUrl = @"https://emma.bg/images/products/damski-pantalon-faded-black-super-skinny-trousers-1.jpg" },

        };

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.Id == productId);
        }
    }
}
