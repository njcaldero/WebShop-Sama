using System;
using System.ComponentModel.DataAnnotations;
namespace WebShop.App.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
