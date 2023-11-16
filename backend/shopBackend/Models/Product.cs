using shopBackend.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace shopBackend.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
        [Range(0,int.MaxValue)]
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public UnitTypeEnum UnitType { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
       
    }
}
