using MediatR;
using AutoMapper;
using CarRental.DataAccess.CQRS.Queries;
using CarRental.DataAccess.CQRS;
using CarRental.ApplicationServices.API.Domain.RentalDataReqAndResp;


namespace CarRental.ApplicationServices.API.Handlers
{
    public class GetRentalsDataHandler : IRequestHandler<GetRentalsDataRequest, GetRentalsDataResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetRentalsDataHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetRentalsDataResponse> Handle(GetRentalsDataRequest request, CancellationToken cancellationToken)
        {
            var query = new GetRentalsDataQuery();
            var rentalsData = await this.queryExecutor.Execute(query);
            var mappedRentalData = this.mapper.Map<List<Domain.Models.RentalData>>(rentalsData);

            var response = new GetRentalsDataResponse()
            {
                Data = mappedRentalData
            };
            return response;
        }
    }
}
