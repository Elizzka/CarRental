using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetRentalsQuery : QueryBase<List<Rental>>
    {
        public int Id { get; set; }
        public override Task<List<Rental>> Execute(CarRentalStorageContext context)
        {
            return context.Rentals.ToListAsync();
        }
    }
}
