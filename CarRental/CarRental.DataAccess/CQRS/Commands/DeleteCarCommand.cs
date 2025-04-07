 using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Commands
{
    public class DeleteCarCommand : CommandBase<int, Car>
    {
        public int Id { get; set; }

        public override async Task<Car> Execute(CarRentalStorageContext context)
        {
            var car = await context.Cars.FirstOrDefaultAsync(c => c.Id == this.Id);
            if (car == null)
            {
                return null; 
            }

            context.Cars.Remove(car);
            await context.SaveChangesAsync();
            return car;
        }
    }
}
