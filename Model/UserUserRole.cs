using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace C_Sharp_Board.Model
{
    public class UserUserRole
    {
        [Key, Column(Order = 0)]
        public int UserId { get; set; }

        [Key, Column(Order = 1)]
        public int RoleId { get; set; }

        [Required, Column(Order = 2)]
        public DateTime CreatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual UserRole Role { get; set; }
    }
}