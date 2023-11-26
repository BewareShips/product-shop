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

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, IHttpContextAccessor httpContextAccessor)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        public IEnumerable<Order> GetAllOrdersAsync()
        {
            return  _orderRepository.GetAll();
        }

        public Order GetOrderByIdAsync(int id)
        {
            return  _orderRepository.GetById(id);
        }
        public void CreateOrder(CreateOrderDto createOrderDto)
        {
            var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var order = new Order
            {
                PersonId = userId,
                OrderStatusId = (int)OrderStatusCategories.New,
                OrderItems = new List<OrderItem>()
            };
            foreach(var item in createOrderDto.OrderItems)
            {
                var product =  _productRepository.GetById(item.Id);
                if (product == null)
                {
                    throw new KeyNotFoundException($"Product with ID {item.Id} not found.");
                }
                var orderItem = new OrderItem
                {
                    ProductId = product.Id,
                    Quantity = item.Quantity,
                    UnitPrice = product.Price,
                };
                order.OrderItems.Add(orderItem);
            }
            order.TotalAmount = order.OrderItems.Sum(x => (x.UnitPrice * x.Quantity));
            _orderRepository.Add(order);
        }
    }
}
