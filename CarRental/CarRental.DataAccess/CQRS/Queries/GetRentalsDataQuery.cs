using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetRentalsDataQuery : QueryBase<List<RentalData>>
    {
        public int Id { get; set; }
        public override Task<List<RentalData>> Execute(CarRentalStorageContext context)
        {
            return context.RentalsData.ToListAsync();
        }
    }
}
