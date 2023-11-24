using shopBackend.Models.Enums;

namespace shopBackend.Services.Interfaces
{
    public interface IUserService
    {
        Task Register(string firstName, string lastName, string email, string password, string address, UserRole role, string phoneNumber = null);
        Task<string> Login(string email, string password);
    }
}
