using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Great_eCommerce_App_From_Scratch.Models.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
