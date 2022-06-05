using Microsoft.EntityFrameworkCore;

namespace board.config
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions options ) : base(options){
            
        }
    }
}