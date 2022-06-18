using C_Sharp_Board.Model;
using Microsoft.EntityFrameworkCore;
namespace C_Sharp_Board.Config
{
   
    public class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options) : base(options)
        {

        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserUserRole> UsersUserRoles { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(p => new { p.Id });

            modelBuilder.Entity<UserUserRole>().HasKey(column => new { column.UserId, column.RoleId });

         
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(column => column.IsDeleted).HasDefaultValue(value: false);
            });
            
            modelBuilder.Entity<User>().HasIndex(column => new { column.Email }).IsUnique(unique:true);
        }
    }
}