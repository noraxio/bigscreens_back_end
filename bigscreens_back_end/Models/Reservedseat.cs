using System.ComponentModel.DataAnnotations;

namespace bigscreens_back_end.Models
{
    public class Reservedseat
    {
        public int Id { get; set; }
        [Required]
        public int Seatnummber { get; set; }

    }
}
