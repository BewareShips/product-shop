using shopBackend.Models;

namespace shopBackend.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task AddUserAsync(Person user);
        Task<Person?> GetUserByEmailAsync(string email);
    }
}
