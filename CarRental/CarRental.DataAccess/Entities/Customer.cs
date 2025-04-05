using System.ComponentModel.DataAnnotations;

namespace CarRental.DataAccess.Entities
{
    public class Customer : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<Rental> Rentals { get; set; }

    }
}
