using CarRental.DataAccess.CQRS.Queries;

namespace CarRental.DataAccess.CQRS
{
    public class QueryExecutor : IQueryExecutor
    {
        private readonly CarRentalStorageContext context;

        public QueryExecutor(CarRentalStorageContext context)
        {
            this.context = context;
        }

        public Task<TResult> Execute<TResult>(QueryBase<TResult> query)
        {
            return query.Execute(context);
        }
    }
}
