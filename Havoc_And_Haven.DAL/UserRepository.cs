using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.DAL
{
    public  class UserRepository
    {
        private readonly HavocAndHavenDbContext _context;

        public UserRepository(HavocAndHavenDbContext context)
        {
            _context = context;
        }   
        public List<User> GetAllUsers()
        {
            return _context.User
                .Include(u => u.Alias)
                .Include(u => u.Name);
        }
    }
}
