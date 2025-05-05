using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Commands
{
    public class UpdateRentalDataCommand : CommandBase<RentalData, RentalData>
    {
        public override async Task<RentalData> Execute(CarRentalStorageContext context)
        {
            var rentalData = await context.RentalsData.FirstOrDefaultAsync(r => r.Id == this.Parameter.Id);
            if (rentalData == null)
            {
                return null;
            }

            rentalData.RentalId = this.Parameter.RentalId;
            rentalData.CarId = this.Parameter.CarId;
            rentalData.PricePerDay = this.Parameter.PricePerDay;
            rentalData.NumberOfDays = this.Parameter.NumberOfDays;

            await context.SaveChangesAsync();
            return rentalData;
        }
    }
}
