using AutoMapper;
using CarRental.ApplicationServices.API.Domain.CustomerReqAndResp;
using CarRental.DataAccess.Entities;

namespace CarRental.ApplicationServices.Mappings
{
    public class CustomersProfile : Profile
    {
        public CustomersProfile()
        {
            this.CreateMap<AddCustomerRequest, Customer>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Email));

            this.CreateMap<Customer, API.Domain.Models.Customer>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Email));
        }
    }
}
