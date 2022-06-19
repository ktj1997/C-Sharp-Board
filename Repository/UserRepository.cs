using C_Sharp_Board.Config;
using C_Sharp_Board.Model;
using C_Sharp_Board.Service.Exception;
using Microsoft.EntityFrameworkCore;

namespace C_Sharp_Board.Repository
{
    public class UserRepository
    {
        private readonly CodeFirstDbContext _dbContext;
        public UserRepository(CodeFirstDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public User FindUserById(int userId)
        {
            User user = _dbContext.Users.FirstOrDefault(user => user.Id == userId);

            return user != null ? user : throw new EntityNotFound("User Not Found");
        }
    }
}