using AutoMapper;
using CarRental.ApplicationServices.API.Domain.Models;

namespace CarRental.ApplicationServices.Mappings
{
    public class EmployeesProfile : Profile
    {
        public EmployeesProfile()
        {
            this.CreateMap<DataAccess.Entities.Employee, Employee>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ForMember(x => x.Surname, y => y.MapFrom(z => z.Surname))
                .ForMember(x => x.PhoneNumber, y => y.MapFrom(z => z.PhoneNumber));
        }
    }
}
