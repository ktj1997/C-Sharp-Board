using C_Sharp_Board.Model;
using Microsoft.EntityFrameworkCore;

namespace Board.Config
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options) : base(options)
        {

        }
        /**
		  * 1. DbSet으로 설정되는 것들은 Entity로 간주된다.
		  * 2. DbSet으로 등록되지 않아도, 연결되어있는 Entity들은 재귀적으로 찾은 후 Entity로 간주된다.
		  */
    }
}