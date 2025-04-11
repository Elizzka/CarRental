using AutoMapper;
using CarRental.DataAccess.Entities;

namespace CarRental.ApplicationServices.Mappings
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            this.CreateMap<User, API.Domain.Models.User>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.FirstName, y => y.MapFrom(z => z.FirstName))
               .ForMember(x => x.LastName, y => y.MapFrom(z => z.LastName));
              // .ForMember(x => x.Password, y => y.MapFrom(z => z.Password));
        }
        //this.CreateMap<GetUsersRequest, User>()
        //        .ForMember(x => x.Brand, y => y.MapFrom(z => z.Brand))
        //        .ForMember(x => x.Model, y => y.MapFrom(z => z.Model))
        //        .ForMember(x => x.YearOfProduction, y => y.MapFrom(z => z.YearOfProduction))
        //        .ForMember(x => x.Availability, y => y.MapFrom(z => z.Availability));
    }
}
