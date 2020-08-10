using App_Great_eCommerce_App_From_Scratch.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Great_eCommerce_App_From_Scratch.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly ShoppingCart shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            this.appDbContext = appDbContext;
            this.shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            //appDbContext.Orders.Add(order);

            var shoppingCartItems = shoppingCart.ShoppingCartItems;
            order.OrderTotal = shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    //OrderId = order.OrderId,
                    ProductId = shoppingCartItem.Product.Id,
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Product.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            appDbContext.Orders.Add(order);

            appDbContext.SaveChanges();
        }
    }
}
