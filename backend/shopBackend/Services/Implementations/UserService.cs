using shopBackend.Models;
using shopBackend.Models.Enums;
using shopBackend.Repository.Interfaces;
using shopBackend.Services.Interfaces;

namespace shopBackend.Services.Implementations
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

        public async Task<string> Login(string email, string password)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null)
            {
                throw new Exception("User was not found");
            }
            bool passwordMatches = _passwordHashService.VerifyPassword(user.Password, password);
            if (!passwordMatches)
            {
                throw new UnauthorizedAccessException("Invalid email or password.");
            }

            try
            {
                return _tokenService.GenerateToken(user);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to generate token.", ex);
            }
        }

        public async Task Register(string firstName, string lastName, string email, string password, string address, string phoneNumber, UserRole role = UserRole.Customer)
        {
            var existingUser = await _userRepository.GetUserByEmailAsync(email);
            if (existingUser != null)
            {
                throw new InvalidOperationException("User with this email already exists.");
            }
            
            var hashedPassword = _passwordHashService.HashPassword(password);
            var person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = hashedPassword,
                Address = address,
                Role = role,
                PhoneNumber = phoneNumber
            };
            await _userRepository.AddUserAsync(person);
        }
    }
}
