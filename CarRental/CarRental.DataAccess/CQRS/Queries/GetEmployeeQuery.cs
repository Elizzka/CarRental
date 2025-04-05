using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetEmployeeQuery : QueryBase<Employee>
    {
        public int Id { get; set; }
        public override async Task<Employee> Execute(CarRentalStorageContext context)
        {
            var employee = await context.Employees.FirstOrDefaultAsync(x => x.Id == this.Id);
            return employee;
        }
    }
}
