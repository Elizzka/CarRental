using AutoMapper;
using CarRental.ApplicationServices.API.Domain.UserReqAndResp;
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

            this.CreateMap<CreateUserRequest, User>()
               .ForMember(x => x.FirstName, y => y.MapFrom(z => z.FirstName))
               .ForMember(x => x.LastName, y => y.MapFrom(z => z.LastName))
               .ForMember(x => x.Password, y => y.MapFrom(z => z.Password));
        }

    }
}
