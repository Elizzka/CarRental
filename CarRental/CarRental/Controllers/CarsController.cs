using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using CarRental.DataAccess;
using CarRental.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design.Internal;

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

        //[HttpGet]
        //[Route("{carId}")]
        //public Car GetCarById(int carId) => this.carRepository.GetById(carId);
    }
}
