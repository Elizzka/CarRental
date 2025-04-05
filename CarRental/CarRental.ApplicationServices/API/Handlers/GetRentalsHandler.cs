using AutoMapper;
using CarRental.ApplicationServices.API.Domain;
using CarRental.DataAccess.CQRS;
using CarRental.DataAccess.CQRS.Queries;
using MediatR;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class GetRentalsHandler : IRequestHandler<GetRentalsRequest, GetRentalsResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetRentalsHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetRentalsResponse> Handle(GetRentalsRequest request, CancellationToken cancellationToken)
        {
            var query = new GetRentalsQuery();
            var rentals = await this.queryExecutor.Execute(query);
            var mappedRental = this.mapper.Map<List<Domain.Models.Rental>>(rentals);

            var response = new GetRentalsResponse()
            {
                Data = mappedRental
            };
            return response;
        }
    }
}
