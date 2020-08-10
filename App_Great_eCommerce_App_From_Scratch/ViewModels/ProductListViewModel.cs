using App_Great_eCommerce_App_From_Scratch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Great_eCommerce_App_From_Scratch.ViewModels
{
    public class ProductListViewModel
    {
        public string Title { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
