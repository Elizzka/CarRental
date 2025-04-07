using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using MediatR;

namespace CarRental.ApplicationServices.API.Domain.RentalReqAndResp
{
    public class UpdateRentalRequest : IRequest<UpdateRentalResponse>
    {
        public int Id { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

    }
}
