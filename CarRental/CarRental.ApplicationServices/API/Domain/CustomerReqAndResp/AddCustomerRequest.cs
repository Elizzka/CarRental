using MediatR;

namespace CarRental.ApplicationServices.API.Domain.CustomerReqAndResp
{
    public class AddCustomerRequest : IRequest<AddCustomerResponse>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
