using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetEmployeesQuery : QueryBase<List<Employee>>
    {
        public int Id { get; set; }
        public override Task<List<Employee>> Execute(CarRentalStorageContext context)
        {
            return context.Employees.ToListAsync();
        }
    }
}
