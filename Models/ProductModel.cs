using System.ComponentModel.DataAnnotations;

namespace AluraMusicAPIRest.Models
{
    public class ProductModel
    {
        
        public int Id { get; set; }
        [Required]
        public string? productName { get; set; }
        [Required]
        public decimal productPrice { get; set; }
        [Required]
        public string? productDescription { get; set; }
        [Required]
        public string? productAlt { get; set; }
        [Required]
        public string? productType { get; set; }
        [Required]
        public string? productImage { get; set; }
    }
}
