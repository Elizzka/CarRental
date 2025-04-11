using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetUsersQuery : QueryBase<List<User>>
    {
        public string Username { get; set; }
        public override Task<List<User>> Execute(CarRentalStorageContext context)
        {
            return context.Users.ToListAsync();
        }
    }
}
