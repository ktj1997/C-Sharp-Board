using C_Sharp_Board.Model;
using Microsoft.EntityFrameworkCore;
namespace C_Sharp_Board.Config
{
    /**
        * Fluent API
        * POCO Class�� Entity�� �����Ѵ�.
        */
    public class CodeFirstDbContext : DbContext
    {
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext> options) : base(options)
        {

        }
        /**
           * DB Table�� ����
           */
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserUserRole> UsersUserRoles { get; set; }
        /**
            * Table ���� �� ����
            */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                    .HasKey(p => new { p.Id });

            /**
                * ����Ű ����
                */
            modelBuilder.Entity<UserUserRole>().HasKey(column => new { column.UserId, column.RoleId });

            /**
                * Entity Default �� ����
                */
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(column => column.IsDeleted).HasDefaultValue(value: false);
            });

            /**
                * Index ����
                */
            modelBuilder.Entity<User>().HasIndex(column => new { column.Email });
        }
    }
}