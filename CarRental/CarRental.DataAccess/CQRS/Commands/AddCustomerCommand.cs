using CarRental.DataAccess.Entities;

namespace CarRental.DataAccess.CQRS.Commands
{
    public class AddCustomerCommand : CommandBase<Customer, Customer>
    {
        public override async Task<Customer> Execute(CarRentalStorageContext context)
        {
            await context.Customers.AddAsync(this.Parameter);
            await context.SaveChangesAsync();
            return this.Parameter;
        }
    }
}
