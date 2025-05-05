using MediatR;

namespace CarRental.ApplicationServices.API.Domain.UserReqAndResp
{
    public class AuthenticateUserRequest : IRequest<AuthenticateUserResponse>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
