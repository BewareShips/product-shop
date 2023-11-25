using shopBackend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace shopBackend.Models.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int StockQuantity { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public UnitTypeEnum UnitType { get; set; }
    }
}
