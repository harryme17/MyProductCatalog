// In MyProductCatalog/Models/Product.cs

using System.ComponentModel.DataAnnotations;

namespace MyProductCatalog.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty; // Default to an empty string to avoid null reference issues

        public string? Description { get; set; } // string? allows this to be null/optional

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 10000.00, ErrorMessage = "Price must be between $0.01 and $10,000.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}