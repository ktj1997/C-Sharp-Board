
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace C_Sharp_Board.Model
{
    public class User
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(20), Column(Order = 1)]
        public string UserName { get; set; }

        [Required, StringLength(20), Column(Order = 2)]
        public string Email { get; set; }

        [Required, StringLength(20), Column(Order = 3)]
        public string Password { get; set; }

        [Required, Column(Order = 4)]
        public DateTime CreatedAt { get; set; }

        [Required, Column(Order = 5)]
        public bool IsDeleted { get; set; }

        [ForeignKey("UserId")]
        public virtual ICollection<UserUserRole> UserUserRoles { get; set; }
    }
}