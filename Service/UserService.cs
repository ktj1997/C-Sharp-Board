using C_Sharp_Board.Model;
using C_Sharp_Board.Repository;
using Microsoft.EntityFrameworkCore;

namespace C_Sharp_Board.Service
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public User FindUser(int userId)
        {
            return _userRepository.FindUserById(userId);
        }
    }
}