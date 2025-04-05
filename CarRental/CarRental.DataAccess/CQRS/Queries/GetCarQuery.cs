using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetCarQuery : QueryBase<Car>
    {
        public int Id { get; set; }
        public override async Task<Car> Execute(CarRentalStorageContext context)
        {
            var car = await context.Cars.FirstOrDefaultAsync(x => x.Id == this.Id);
            return car;
        }
    }
}
