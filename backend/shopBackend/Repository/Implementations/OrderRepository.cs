using Microsoft.EntityFrameworkCore;
using shopBackend.Data;
using shopBackend.Models;
using shopBackend.Repository.Interfaces;

namespace shopBackend.Repository.Implementations
{
    public class OrderRepository : IOrderRepository
    {

        private readonly ShopContext _context;

        public OrderRepository(ShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetByIdAsync(int id) 
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                throw new KeyNotFoundException($"Order with ID {id} not found.");
            }
            return order;
        }

        public async Task AddAsync(Order order)
        {
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }
    }
}
