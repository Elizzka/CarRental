//using CarRental.DataAccess.Entities;

//namespace CarRental.DataAccess.CQRS.Commands
//{
//    public class CreateUserCommand : CommandBase<User, User>
//    {
//        public override async Task<User> Execute(CarRentalStorageContext context)
//        {
//            await context.Users.AddAsync(this.Parameter);
//            await context.SaveChangesAsync();
//            return this.Parameter;
//        }
//    }
//}
