using shopBackend.Models;
using shopBackend.Models.Dto;
using shopBackend.Models.Enums;
using shopBackend.Repository.Interfaces;
using shopBackend.Services.Interfaces;
using System.Security.Claims;

namespace shopBackend.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _orderRepository.GetByIdAsync(id);
        }

        public async Task CreateOrderAsync(CreateOrderDto createOrderDto)
        {
            var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (userId == null)
            {
                throw new UnauthorizedAccessException("User is not authenticated.");
            }

            var order = new Order
            {
                PersonId = userId,
                OrderStatusId = (int)OrderStatusCategories.New,
                OrderItems = new List<OrderItem>()
            };

            foreach (var item in createOrderDto.OrderItems)
            {
                var product = await _productRepository.GetByIdAsync(item.Id);
                if (product == null)
                {
                    throw new KeyNotFoundException($"Product with ID {item.Id} not found.");
                }

                var orderItem = new OrderItem
                {
                    ProductId = product.Id,
                    Quantity = item.Quantity,
                    UnitPrice = product.Price
                };

                order.OrderItems.Add(orderItem);
            }

            order.TotalAmount = order.OrderItems.Sum(x => x.UnitPrice * x.Quantity);
            await _orderRepository.AddAsync(order);
        }
    }
}
