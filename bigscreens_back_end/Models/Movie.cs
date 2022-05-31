using System.ComponentModel.DataAnnotations;

namespace bigscreens_back_end.Models
{
    public class Movie
    {
        public Movie()
        {
            // tharf ad skoda
            Shows = new List<Show>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
        public int RunTime  { get; set; }
        [Required]
        [MaxLength(255)]
        public string Genres { get; set; }
        [Required]
        public string PlotSummery   { get; set; }
        [Required]
        public int PgLevel { get; set; }
        public int Rating   { get; set; }


    }
}
