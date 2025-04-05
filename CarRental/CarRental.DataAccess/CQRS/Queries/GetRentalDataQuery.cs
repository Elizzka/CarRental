using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetRentalDataQuery : QueryBase<RentalData>
    {
        public int Id { get; set; }
        public override async Task<RentalData> Execute(CarRentalStorageContext context)
        {
            var rentalData = await context.RentalsData.FirstOrDefaultAsync(x => x.Id == this.Id);
            return rentalData;
        }
    }
}
