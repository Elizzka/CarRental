using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarsController : ApiControllerBase
    {
        public CarsController(IMediator mediator, ILogger<CarsController> logger) : base(mediator) 
        {
            logger.LogInformation("We are in Cars");
        } 

        [HttpGet]
        [Route("")]
        public Task<IActionResult> GetAllCars([FromQuery] GetCarsRequest request)
        {
            return this.HandleRequest<GetCarsRequest, GetCarsResponse>(request);
        }

        [HttpPost]
        [Route("")]
        public Task<IActionResult> AddCar([FromBody] AddCarRequest request)
        {
            return this.HandleRequest<AddCarRequest, AddCarResponse>(request);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task<IActionResult> DeleteCar([FromRoute] int id)
        {
            var request = new DeleteCarRequest() { Id = id };
            return this.HandleRequest<DeleteCarRequest, DeleteCarResponse>(request);
        }
    }
}
