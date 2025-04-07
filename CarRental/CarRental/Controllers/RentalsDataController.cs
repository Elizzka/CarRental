using Microsoft.AspNetCore.Mvc;
using MediatR;
using CarRental.ApplicationServices.API.Domain.RentalDataReqAndResp;
using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;

namespace CarRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalsDataController : ControllerBase
    {
        private readonly IMediator mediator;

        public RentalsDataController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllRentalsData([FromQuery] GetRentalsDataRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateRentalData([FromRoute] int id, [FromBody] UpdateRentalDataRequest request)
        {
            request.Id = id;
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }
    }
}