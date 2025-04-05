using CarRental.DataAccess.CQRS.Commands;

namespace CarRental.DataAccess.CQRS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly CarRentalStorageContext context;

        public CommandExecutor(CarRentalStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command)
        {
            return command.Execute(this.context);
        }
    }
}
