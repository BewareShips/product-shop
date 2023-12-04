using shopBackend.Models.Enums;

namespace shopBackend.Services.Interfaces
{
    public interface IUserService
    {
        Task Register(string firstName, string lastName, string email, string password, string address,  string phoneNumber, UserRole role );
        Task<string> Login(string email, string password);
    }
}
