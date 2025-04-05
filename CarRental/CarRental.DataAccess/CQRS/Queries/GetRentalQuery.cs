using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetRentalQuery : QueryBase<Rental>
    {
        public int Id { get; set; }
        public override async Task<Rental> Execute(CarRentalStorageContext context)
        {
            var rental = await context.Rentals.FirstOrDefaultAsync(x => x.Id == this.Id);
            return rental;
        }
    }
}
