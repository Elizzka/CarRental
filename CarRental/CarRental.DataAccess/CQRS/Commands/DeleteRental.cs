using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Commands
{
    public class DeleteRental : CommandBase<int, Rental>
    {
        public int Id { get; set; }

        public override async Task<Rental> Execute(CarRentalStorageContext context)
        {
            var rental = await context.Rentals.FirstOrDefaultAsync(c => c.Id == this.Id);
            if (rental == null)
            {
                return null; 
            }

            context.Rentals.Remove(rental);
            await context.SaveChangesAsync();
            return rental;
        }
    }
}
