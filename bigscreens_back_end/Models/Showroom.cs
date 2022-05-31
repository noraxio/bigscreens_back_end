using System.ComponentModel.DataAnnotations;

namespace bigscreens_back_end.Models
{
    public class Showroom
    {

        public int Id { get; set; }
        [Required]
        public int TotalSeats { get; set; }
        [Required]
        public int ScreenSize { get; set; }
        public List<Show> Shows { get; set; }



    }
}
