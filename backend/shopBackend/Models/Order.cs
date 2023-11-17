using System.ComponentModel.DataAnnotations;

namespace shopBackend.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }

    }
}
