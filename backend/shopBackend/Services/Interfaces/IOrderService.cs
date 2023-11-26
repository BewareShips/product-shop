using shopBackend.Models;
using shopBackend.Models.Dto;

namespace shopBackend.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(CreateOrderDto createOrderDto);
        Task<Order> GetOrderByIdAsync(int id);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
    }
}
