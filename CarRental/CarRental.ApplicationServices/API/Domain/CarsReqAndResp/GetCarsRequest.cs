using MediatR;

namespace CarRental.ApplicationServices.API.Domain.CarsReqAndResp
{
    public class GetCarsRequest : IRequest<GetCarsResponse>
    {
        public string Brand { get; set; }
    }
}
