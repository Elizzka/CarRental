using System.ComponentModel.DataAnnotations;

namespace CarRental.DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string Password { get; set; }
    }
}
