using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Pongo.BusinessLogic
{
    public class UserRepository : IUserRepository
    {
        private readonly PongoContext _context;
        private readonly PongoConfiguration _configuration;

        public UserRepository(PongoContext context, PongoConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public void DeleteUser(int userId)
        {
            User deleteUser = _context.Users.FirstOrDefault(u => u.Id == userId);
            _context.Users.Remove(deleteUser);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Add(user);
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public User GetUser(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.Id == userId);
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void InsertUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
