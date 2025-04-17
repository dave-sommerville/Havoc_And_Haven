using Havoc_And_Haven.Models;
using Microsoft.EntityFrameworkCore;

namespace Havoc_And_Haven.DAL
{
    public class UserRepository
    {
        private readonly HavocAndHavenDbContext _context;

        public UserRepository(HavocAndHavenDbContext context)
        {
            _context = context;
        }

        public List<Users> GetAllUsers()
        {
            return _context.Users
                .Include(u => u.Headquarters)
                .Include(u => u.Lair)
                .ToList();
        }

        public Users? GetUserById(int id)
        {
            return _context.Users
                .Include(u => u.Headquarters)
                .Include(u => u.Lair)
                .FirstOrDefault(u => u.UserId == id);
        }

        public void AddUser(Users user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving user: {ex.Message}");
                throw;
            }
        }

        public void UpdateUser(Users user)
        {
            Users? existingUser = _context.Users.Find(user.UserId);
            if (existingUser != null)
            {
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Email = user.Email;
                existingUser.Alias = user.Alias;
                existingUser.OriginStory = user.OriginStory;
                existingUser.Role = user.Role;
                existingUser.PowerLevel = user.PowerLevel;
                existingUser.HeadquartersId = user.HeadquartersId;
                existingUser.LairId = user.LairId;

                _context.Users.Update(existingUser);
                _context.SaveChanges();
            }
        }

        public void DeleteUser(int userId)
        {
            Users? user = _context.Users.Find(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
