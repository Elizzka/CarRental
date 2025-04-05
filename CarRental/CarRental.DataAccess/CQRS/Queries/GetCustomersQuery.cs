using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetCustomersQuery : QueryBase<List<Customer>>
    {
        public int Id { get; set; }
        public override Task<List<Customer>> Execute(CarRentalStorageContext context)
        {
            return context.Customers.ToListAsync();
        }
    }
}
