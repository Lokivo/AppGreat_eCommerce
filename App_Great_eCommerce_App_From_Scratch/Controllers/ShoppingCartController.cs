using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Great_eCommerce_App_From_Scratch.Models;
using App_Great_eCommerce_App_From_Scratch.Models.Interfaces;
using App_Great_eCommerce_App_From_Scratch.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App_Great_eCommerce_App_From_Scratch.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            this.productRepository = productRepository;
            this.shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = this.shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int Id)
        {
            var selectedPie = productRepository.AllProducts.FirstOrDefault(p => p.Id == Id);

            if (selectedPie != null)
            {
                shoppingCart.AddToCart(selectedPie, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int Id)
        {
            var selectedPie = productRepository.AllProducts.FirstOrDefault(p => p.Id == Id);

            if (selectedPie != null)
            {
                shoppingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}
