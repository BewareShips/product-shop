using shopBackend.Models;
using shopBackend.Models.Dto;

namespace shopBackend.Services.Interfaces
{
    public interface IOrderService
    {
        public void CreateOrder(CreateOrderDto createOrderDto);
        public Order GetOrderByIdAsync(int id);
        public IEnumerable<Order> GetAllOrdersAsync();
    }
}
