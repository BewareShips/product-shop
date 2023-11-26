using System.ComponentModel.DataAnnotations;

namespace shopBackend.Models.Dto
{
    public class CreateOrderDto
    {
        public ICollection<CreateOrderItemDto> OrderItems { get; set; }
    }
}
