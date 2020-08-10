using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Great_eCommerce_App_From_Scratch.Models.Interfaces;
using App_Great_eCommerce_App_From_Scratch.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App_Great_eCommerce_App_From_Scratch.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                WelcomeText = "Welcome!"
            };

            return View(homeViewModel);
        }
    }
}

