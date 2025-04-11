using AutoMapper;
using CarRental.ApplicationServices.API.Domain.UserReqAndResp;
using CarRental.DataAccess.CQRS.Queries;
using CarRental.DataAccess.CQRS;
using MediatR;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class GetUsersHandler : IRequestHandler<GetUsersRequest, GetUsersResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public GetUsersHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<GetUsersResponse> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUsersQuery();
            var users = await this.queryExecutor.Execute(query);
            var mappedUser = this.mapper.Map<List<Domain.Models.User>>(users);

            var response = new GetUsersResponse()
            {
                Data = mappedUser
            };
            return response;
        }
    }
}
