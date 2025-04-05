using CarRental.DataAccess.CQRS.Commands;

namespace CarRental.DataAccess.CQRS
{
    public interface ICommandExecutor
    {
        Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command);
    }
}
