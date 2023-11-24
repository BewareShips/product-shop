using shopBackend.Models.Enums;
using shopBackend.Services.Interfaces;

namespace shopBackend.Services
{
    public class UserService : IUserService
    {
        private readonly IPasswordHashService _passwordHashService;
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepository;

        public UserService(IPasswordHashService passwordHashService, ITokenService tokenService, IUserRepository userRepository)
        {
            _passwordHashService = passwordHashService;
            _tokenService = tokenService;
            _userRepository = userRepository;
        }

        public Task<string> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task Register(string firstName, string lastName, string email, string password, string address, UserRole role, string phoneNumber = null)
        {
            throw new NotImplementedException();
        }
    }
}
