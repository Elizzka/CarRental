using CarRental.ApplicationServices.API.Domain.EmployeeReqAndResp;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ApiControllerBase
    {
        public EmployeesController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllEmployees([FromQuery] GetEmployeesRequest request)
        {
            return this.HandleRequest<GetEmployeesRequest, GetEmployeesResponse>(request);
        }
    }
}
