using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetCustomerQuery : QueryBase<Customer>
    {
        public int Id { get; set; }
        public override async Task<Customer> Execute(CarRentalStorageContext context)
        {
            var customer = await context.Customers.FirstOrDefaultAsync(x => x.Id == this.Id);
            return customer;
        }
    }
}
