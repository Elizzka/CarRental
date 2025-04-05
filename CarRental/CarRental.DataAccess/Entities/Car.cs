using System.ComponentModel.DataAnnotations;

namespace CarRental.DataAccess.Entities
{
    public class Car : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public bool Availability { get; set; }

        public List<RentalData> RentalsData { get; set; }
    }
}
