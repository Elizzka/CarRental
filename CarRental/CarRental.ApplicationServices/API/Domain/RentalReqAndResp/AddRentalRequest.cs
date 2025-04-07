using MediatR;

namespace CarRental.ApplicationServices.API.Domain.RentalReqAndResp
{
    public class AddRentalRequest : IRequest<AddRentalResponse>
    {
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
    }
}
