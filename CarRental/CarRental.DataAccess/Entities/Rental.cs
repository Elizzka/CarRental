using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.DataAccess.Entities
{
    public class Rental : EntityBase
    {
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<RentalData> RentalsData { get; set; }


    }
}
