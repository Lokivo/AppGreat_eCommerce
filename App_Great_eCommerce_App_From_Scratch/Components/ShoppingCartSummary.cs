using App_Great_eCommerce_App_From_Scratch.Models;
using App_Great_eCommerce_App_From_Scratch.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Great_eCommerce_App_From_Scratch.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {

            var items = this.shoppingCart.GetShoppingCartItems();
            this.shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = this.shoppingCart,
                ShoppingCartTotal = this.shoppingCart.GetShoppingCartTotal()

            };
            return View(shoppingCartViewModel);
        }
    }
}
