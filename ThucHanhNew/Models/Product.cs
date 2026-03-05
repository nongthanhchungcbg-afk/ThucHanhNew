using System.ComponentModel.DataAnnotations;

namespace ThucHanhNew.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 2)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Range(0.01, 10000, ErrorMessage = "Price must be greater than 0 and less than 10000")]
        public decimal Price { get; set; }
    }
}

