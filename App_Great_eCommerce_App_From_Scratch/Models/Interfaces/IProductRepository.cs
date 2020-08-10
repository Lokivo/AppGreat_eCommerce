using System.Collections;
using System.Collections.Generic;

namespace App_Great_eCommerce_App_From_Scratch.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        Product GetProductById(int productId);
    }
}
