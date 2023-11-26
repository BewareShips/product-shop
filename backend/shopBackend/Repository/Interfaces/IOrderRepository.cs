using shopBackend.Models;

namespace shopBackend.Repository.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Order GetById(int id);
        void Add(Order order);
    }
}
