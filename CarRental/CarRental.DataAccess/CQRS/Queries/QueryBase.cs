﻿namespace CarRental.DataAccess.CQRS.Queries
{
    public abstract class QueryBase<TResult>
    {
        public abstract Task<TResult> Execute(CarRentalStorageContext context);
    }
}
