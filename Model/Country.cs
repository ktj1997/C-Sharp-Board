using System.ComponentModel.DataAnnotations;

namespace C_Sharp_Board.Model
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        /**
		  * 1 : N 관계를 풀어낸다.
		  * 관계의 주인이 아니기 떄문에 FK를 갖고 있지 않다.
		  * ICollection 타입으로 받을 수 있다.
		  */
        public virtual IList<Hotel> Hotels { get; set; }
    }
}