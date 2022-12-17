using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Restaurant.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(450)]
        public string Name { get; set; }

        [Range(1,1000)]
        public double Price { get; set; }

        [MaxLength(450)]
        public string Description { get; set; }

        [MaxLength(450)]
        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
