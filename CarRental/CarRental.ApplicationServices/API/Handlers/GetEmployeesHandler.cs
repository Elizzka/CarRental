using AutoMapper;
using CarRental.ApplicationServices.API.Domain.EmployeeReqAndResp;
using CarRental.DataAccess.CQRS;
using CarRental.DataAccess.CQRS.Queries;
using MediatR;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class GetEmployeesHandler : IRequestHandler<GetEmployeesRequest, GetEmployeesResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetEmployeesHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetEmployeesResponse> Handle(GetEmployeesRequest request, CancellationToken cancellationToken)
        {
            var query = new GetEmployeesQuery();
            var employees = await this.queryExecutor.Execute(query);
            var mappedEmployee = this.mapper.Map<List<Domain.Models.Employee>>(employees);

            var response = new GetEmployeesResponse()
            {
                Data = mappedEmployee
            };
            return response;
        }
    }
}
