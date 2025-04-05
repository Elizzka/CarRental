using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly IMediator mediator;

        public CarsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllCars([FromQuery] GetCarsRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> AddCar([FromBody] AddCarRequest request)
        {
            var response = await this.mediator.Send(request);
            return this.Ok(response);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteCar([FromRoute] int id)
        {
            var request = new DeleteCarRequest() { Id = id };
            var response = await this.mediator.Send(request);

            if (response.Data == null) 
            {
                return NotFound(new { message = "Car not found" });
            }

            return NoContent();
        }
    }
}


//[HttpGet]
//[Route("{carId}")]
//public Car GetCarById(int carId) => this.carRepository.GetById(carId);