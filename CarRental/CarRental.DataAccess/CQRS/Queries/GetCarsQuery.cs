using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetCarsQuery : QueryBase<List<Car>>
    {
        public string Brand { get; set; }
        public override Task<List<Car>> Execute(CarRentalStorageContext context)
        {
            if (string.IsNullOrWhiteSpace(this.Brand))
            {
                return context.Cars.ToListAsync();
            }
               
            return context.Cars.Where(x => x.Brand == this.Brand).ToListAsync();
        }
    }
}
