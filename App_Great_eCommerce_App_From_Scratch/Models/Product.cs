using System.ComponentModel.DataAnnotations.Schema;

namespace App_Great_eCommerce_App_From_Scratch.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
