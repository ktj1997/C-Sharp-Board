using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace C_Sharp_Board.Model
{
    public class UserRole
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Column(Order = 1)]
        public string Name { get; set; }

        [ForeignKey("RoleId")]
        public ICollection<UserUserRole> UserUserRoles { get; set; }
    }
}