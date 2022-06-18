using C_Sharp_Board.Model;
using Microsoft.EntityFrameworkCore;

namespace C_Sharp_Board.Config
{
    public class DbFirstDbContext : DbContext
    {
        public DbFirstDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}