using CarRental.DataAccess.CQRS.Queries;

namespace CarRental.DataAccess.CQRS
{
    public interface IQueryExecutor
    {
        Task<TResult> Execute<TResult>(QueryBase<TResult> query);
    }
}
