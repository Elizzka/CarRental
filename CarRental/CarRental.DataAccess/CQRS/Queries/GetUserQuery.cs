using CarRental.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.DataAccess.CQRS.Queries
{
    public class GetUserQuery : QueryBase<User>
    {
        public string Username { get; set; }
        public override  Task<User> Execute(CarRentalStorageContext context)
        {
            return context.Users.FirstOrDefaultAsync(x => x.Username == this.Username);
        }
    }
}
