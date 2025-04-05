using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetCarsQuery : QueryBase<List<Car>>
    {
        public string Brand { get; set; }
        public override Task<List<Car>> Execute(CarRentalStorageContext context)
        {
            //context.Cars.ToListAsync();     jesli brand nie wystepuje, zrobic ifa
            return context.Cars.Where(x => x.Brand == this.Brand).ToListAsync();
        }
    }
}
