using System.ComponentModel.DataAnnotations;

namespace bigscreens_back_end.Models
{
    public class UserAccount
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        public int Phonenummber { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address   { get; set; }

    }
}
