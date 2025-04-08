using CarRental.ApplicationServices.API.Domain.CustomerReqAndResp;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ApiControllerBase
    {
        public CustomersController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllCustomers([FromQuery] GetCustomersRequest request)
        {
            return this.HandleRequest<GetCustomersRequest, GetCustomersResponse>(request);

        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddCustomer([FromBody] AddCustomerRequest request)
        {
            return this.HandleRequest<AddCustomerRequest, AddCustomerResponse>(request);

        }
    }
}
