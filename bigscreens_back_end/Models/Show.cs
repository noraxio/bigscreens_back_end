using System.ComponentModel.DataAnnotations;

namespace bigscreens_back_end.Models
{
    public class Show
    {

        public Show()
        {
            Movies = new List<Movie>();
        }

        public int Id { get; set; }
        [Required]
        public int ShowTime { get; set; }
        public List<Showroom> Showrooms { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Soldseat> Soldseats { get; set; }
        public List<Reservedseat> Reservedseats { get; set; }
    }
}
