using AutoMapper;
using CarRental.ApplicationServices.API.Domain.CustomerReqAndResp;
using CarRental.DataAccess.CQRS;
using CarRental.DataAccess.CQRS.Queries;
using MediatR;


namespace CarRental.ApplicationServices.API.Handlers
{
    public class GetCustomersHandler : IRequestHandler<GetCustomersRequest, GetCustomersResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetCustomersHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetCustomersResponse> Handle(GetCustomersRequest request, CancellationToken cancellationToken)
        {
            var query = new GetCustomersQuery();
            var customers = await this.queryExecutor.Execute(query);
            var mappedCustomer = this.mapper.Map<List<Domain.Models.Customer>>(customers);

            var response = new GetCustomersResponse()
            {
                Data = mappedCustomer
            };
            return response;
        }
    }
}
