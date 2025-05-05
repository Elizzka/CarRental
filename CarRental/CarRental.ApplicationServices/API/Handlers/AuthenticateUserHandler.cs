using AutoMapper;
using CarRental.ApplicationServices.API.Domain.UserReqAndResp;
using CarRental.Authentication;
using CarRental.DataAccess.CQRS;
using CarRental.DataAccess.CQRS.Queries;
using MediatR;

namespace CarRental.ApplicationServices.API.Handlers
{
    public class AuthenticateUserHandler : IRequestHandler<AuthenticateUserRequest, AuthenticateUserResponse>
    {
        private readonly IMapper mapper;
        private readonly IQueryExecutor queryExecutor;

        public AuthenticateUserHandler(IMapper mapper, IQueryExecutor queryExecutor)
        {
            this.mapper = mapper;
            this.queryExecutor = queryExecutor;
        }

        public async Task<AuthenticateUserResponse> Handle(AuthenticateUserRequest request, CancellationToken cancellationToken)
        {
            var query = new GetUserQuery()
            {
                Username = request.Username
            };

            var user = await queryExecutor.Execute(query);

            if (user == null || !PasswordHasher.VerifyPassword(request.Password, user.Password, user.Salt))
            {
                throw new Exception("Invalid username or password");
            }

            var mappedUser = mapper.Map<Domain.Models.User>(user); // jeżeli masz model w API.Domain.Models

            var response = new AuthenticateUserResponse()
            {
                Data = mappedUser
            };

            return response;
        }
    }
}
