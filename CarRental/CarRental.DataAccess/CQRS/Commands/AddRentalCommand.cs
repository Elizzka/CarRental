using CarRental.DataAccess.Entities;

namespace CarRental.DataAccess.CQRS.Commands
{
    public class AddRentalCommand : CommandBase<Rental, Rental>
    {
        public override async Task<Rental> Execute(CarRentalStorageContext context)
        {
            await context.Rentals.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
