using CarRental.DataAccess.Entities;

namespace CarRental.DataAccess.CQRS.Commands
{
    public class AddCarCommand : CommandBase<Car, Car>
    {
        public override async Task<Car> Execute(CarRentalStorageContext context)
        {
            await context.Cars.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
