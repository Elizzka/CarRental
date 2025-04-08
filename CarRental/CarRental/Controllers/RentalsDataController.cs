using Microsoft.AspNetCore.Mvc;
using MediatR;
using CarRental.ApplicationServices.API.Domain.RentalDataReqAndResp;
using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;
using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;

namespace CarRental.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentalsDataController : ApiControllerBase
    {
        public RentalsDataController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllRentalsData([FromQuery] GetRentalsDataRequest request)
        {
            return this.HandleRequest<GetRentalsDataRequest, GetRentalsDataResponse>(request);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<IActionResult> UpdateRentalData([FromRoute] int id, [FromBody] UpdateRentalDataRequest request)
        {
            request.Id = id;
            return this.HandleRequest<UpdateRentalDataRequest, UpdateRentalDataResponse>(request);

        }
    }
}