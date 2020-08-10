using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Great_eCommerce_App_From_Scratch.Models.Interfaces;
using App_Great_eCommerce_App_From_Scratch.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App_Great_eCommerce_App_From_Scratch.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public ViewResult List()
        {
            ProductListViewModel productList = new ProductListViewModel();
            productList.Products = this.productRepository.AllProducts;
            productList.Title = "All Products";

            return View(productList);
        }

        public IActionResult Details(int id)
        {
            var product = this.productRepository.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
