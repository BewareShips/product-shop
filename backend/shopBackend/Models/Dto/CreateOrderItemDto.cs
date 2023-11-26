using System.ComponentModel.DataAnnotations;

namespace shopBackend.Models.Dto
{
    public class CreateOrderItemDto
    {
       
        public int Id { get; set; }
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
