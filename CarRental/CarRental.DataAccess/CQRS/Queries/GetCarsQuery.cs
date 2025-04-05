using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetCarsQuery : QueryBase<List<Car>>
    {
        public int Id { get; set; }
        public override Task<List<Car>> Execute(CarRentalStorageContext context)
        {
            return context.Cars.ToListAsync();
        }
    }
}
