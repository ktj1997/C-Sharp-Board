using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace C_Sharp_Board.Model
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        /**
		  * nameOf를 사용함으로 해서, string으로 관리하지 않게된다.
		  * property로 관리를 하게됨으로 타입 안정성을 얻게된다.
		  */
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}