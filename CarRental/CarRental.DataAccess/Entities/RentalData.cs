using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.DataAccess.Entities
{
    public class RentalData : EntityBase
    {
        [ForeignKey("Rental")]
        public int RentalId { get; set; }
        public Rental Rental { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }   
        public Car Car { get; set; }
        public int PricePerDay { get; set; }
        public int NumberOfDays { get; set; }

    }
}
