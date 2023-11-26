using Microsoft.EntityFrameworkCore;
using shopBackend.Data;
using shopBackend.Models;
using shopBackend.Repository.Interfaces;

namespace shopBackend.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {

        private readonly ShopContext _context;

        public UserRepository(ShopContext context)
        {
            _context = context;
        }
        public async Task AddUserAsync(Person user)
        {
            _context.Persons.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<Person?> GetUserByEmailAsync(string email)
        {
            return await _context.Persons.SingleOrDefaultAsync(u => u.Email == email);
        }
    }
}
