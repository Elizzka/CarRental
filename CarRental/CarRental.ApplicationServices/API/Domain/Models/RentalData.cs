using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.ApplicationServices.API.Domain.Models
{
    public class RentalData
    {
        public int Id { get; set; }
        [ForeignKey("Car")]
        public int CarId { get; set; }
        public int PricePerDay { get; set; }
        public int NumberOfDays { get; set; }
    }
}
