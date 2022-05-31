using System.ComponentModel.DataAnnotations;

namespace bigscreens_back_end.Models
{
    public class Soldseat
    {
        public int Id { get; set; }
        [Required]
        public int TicketNummber { get; set; }
        [Required]
        public int SeatNummber { get; set; }
        [Required]
        public int UserId { get; set; }
        public List<UserAccount> UserAccounts { get; set; }

    }
}
