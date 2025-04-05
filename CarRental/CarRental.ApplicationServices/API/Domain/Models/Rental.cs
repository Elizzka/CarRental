using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.ApplicationServices.API.Domain.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}
