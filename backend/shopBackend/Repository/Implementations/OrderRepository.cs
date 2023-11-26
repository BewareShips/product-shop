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
        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.Find(id); ;
        }
        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
