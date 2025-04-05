using AutoMapper;
using CarRental.ApplicationServices.API.Domain.Models;

namespace CarRental.ApplicationServices.Mappings
{
    public class CustomersProfile : Profile
    {
        public CustomersProfile()
        {
            this.CreateMap<DataAccess.Entities.Customer, Customer>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname))
                .ForMember(x => x.Email, y => y.MapFrom(z => z.Email));

        }
    }
}
