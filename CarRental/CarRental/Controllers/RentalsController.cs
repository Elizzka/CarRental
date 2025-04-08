using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalsController : ApiControllerBase
    {
        public RentalsController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllRentals([FromQuery] GetRentalsRequest request)
        {
            return this.HandleRequest<GetRentalsRequest, GetRentalsResponse>(request);
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddRental([FromBody] AddRentalRequest request)
        {
            return this.HandleRequest<AddRentalRequest, AddRentalResponse>(request);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<IActionResult> UpdateRental([FromRoute] int id, [FromBody] UpdateRentalRequest request)
        {
            request.Id = id;
            return this.HandleRequest<UpdateRentalRequest, UpdateRentalResponse>(request);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task<IActionResult> DeleteRental([FromRoute] int id)
        {
            var request = new DeleteRentalRequest() { Id = id };
            return this.HandleRequest<DeleteRentalRequest, DeleteRentalResponse>(request);
        }
    }
}
