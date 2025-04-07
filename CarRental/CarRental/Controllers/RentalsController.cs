using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalsController : ControllerBase
    {
        private readonly IMediator mediator;

        public RentalsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllRentals([FromQuery] GetRentalsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateRental([FromRoute] int id, [FromBody] UpdateRentalRequest request)
        {
            request.Id = id;
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteRental([FromRoute] int id)
        {
            var request = new DeleteRentalRequest() { Id = id };
            var response = await this.mediator.Send(request);

            if (response.Data == null)
            {
                return NotFound(new { message = "Rental not found" });
            }

            return NoContent();
        }
    }
}
