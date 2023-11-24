using shopBackend.Models;

namespace shopBackend.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(Person user);
    }
}
