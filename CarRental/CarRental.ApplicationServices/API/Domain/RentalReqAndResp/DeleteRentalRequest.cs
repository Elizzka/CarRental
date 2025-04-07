using MediatR;

namespace CarRental.ApplicationServices.API.Domain.RentalReqAndResp
{
    public class DeleteRentalRequest : IRequest<DeleteRentalResponse>
    {
        public int Id { get; set; }
    }
}
