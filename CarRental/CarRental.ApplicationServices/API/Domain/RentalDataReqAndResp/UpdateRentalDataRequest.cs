using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;
using MediatR;

namespace CarRental.ApplicationServices.API.Domain.RentalDataReqAndResp
{
    public class UpdateRentalDataRequest : IRequest<UpdateRentalDataResponse>
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int PricePerDay { get; set; }
        public int NumberOfDays { get; set; }
    }
}
