using System.ComponentModel.DataAnnotations;

namespace CarRental.DataAccess.Entities
{
    public class Employee : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public List<Rental> Rentals { get; set; }

    }
}
