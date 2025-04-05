using MediatR;

namespace CarRental.ApplicationServices.API.Domain.CarsReqAndResp
{
    public class AddCarRequest : IRequest<AddCarResponse>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public bool Availability { get; set; }
    }
}
