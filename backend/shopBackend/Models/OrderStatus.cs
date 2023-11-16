using shopBackend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace shopBackend.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public OrderStatusEnum StatusName { get; set; }
        public ICollection<Order>Orders { get; set; }
    }
}
