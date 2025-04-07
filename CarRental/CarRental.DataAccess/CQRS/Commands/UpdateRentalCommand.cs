using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Commands
{
    public class UpdateRentalCommand : CommandBase<Rental, Rental>
    {
        public override async Task<Rental> Execute(CarRentalStorageContext context)
        {
            var rental = await context.Rentals.FirstOrDefaultAsync(r => r.Id == this.Parameter.Id);
            if (rental == null)
            {
                return null;
            }

            rental.RentalDate = this.Parameter.RentalDate;
            rental.ReturnDate = this.Parameter.ReturnDate;
            rental.CustomerId = this.Parameter.CustomerId;
            rental.EmployeeId = this.Parameter.EmployeeId;


            await context.SaveChangesAsync();
            return rental;
        }
    }
}
