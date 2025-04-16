using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.DAL
{
    public  class UsersRepository
    {
        private readonly HavocAndHavenDbContext _context;

        public UsersRepository(HavocAndHavenDbContext context)
        {
            _context = context;
        }   
        //public List<Users> GetAllUsers()
        ////{
        ////    return _context.Users
        ////        .Include(u => u.Alias)
        ////        .Include(u => u.Name);
        ////}
    }
}
