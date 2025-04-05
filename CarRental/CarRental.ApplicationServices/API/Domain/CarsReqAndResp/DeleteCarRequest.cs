using MediatR;

namespace CarRental.ApplicationServices.API.Domain.CarsReqAndResp
{
    public class DeleteCarRequest : IRequest<DeleteCarResponse>
    {
        public int Id { get; set; }
    }
}
