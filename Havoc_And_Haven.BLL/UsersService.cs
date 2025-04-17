using Havoc_And_Haven.DAL;
using Havoc_And_Haven.Models;

namespace Havoc_And_Haven.BLL
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<Users> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public Users? GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public void AddUser(Users user)
        {
            Console.WriteLine($"Registering user: {user.Alias}");
            _userRepository.AddUser(user);
        }

        public void UpdateUser(Users user)
        {
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
