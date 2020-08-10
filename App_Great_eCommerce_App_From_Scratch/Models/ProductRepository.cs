using App_Great_eCommerce_App_From_Scratch.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Great_eCommerce_App_From_Scratch.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Product> AllProducts
        {
            get { return this.appDbContext.Products; }
        }

        public Product GetProductById(int productId)
        {
            return this.appDbContext.Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
