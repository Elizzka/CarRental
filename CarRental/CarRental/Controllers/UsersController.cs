using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using CarRental.ApplicationServices.API.Domain.UserReqAndResp;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ApiControllerBase
    {
        public UsersController(IMediator mediator)
            : base(mediator) 
        {
            
        }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAll([FromQuery] GetUsersRequest request)
        {
            return this.HandleRequest<GetUsersRequest, GetUsersResponse>(request);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("")]
        public Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            return this.HandleRequest<CreateUserRequest, CreateUserResponse>(request);
        }
    }
}
