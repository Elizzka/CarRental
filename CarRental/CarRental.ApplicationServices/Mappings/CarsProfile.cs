using AutoMapper;
using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using CarRental.DataAccess.Entities;


namespace CarRental.ApplicationServices.Mappings
{
    public class CarsProfile : Profile
    {
        public CarsProfile()
        {
            this.CreateMap<AddCarRequest, Car>()
                .ForMember(x => x.Brand, y => y.MapFrom(z => z.Brand))
                .ForMember(x => x.Model, y => y.MapFrom(z => z.Model))
                .ForMember(x => x.YearOfProduction, y => y.MapFrom(z => z.YearOfProduction))
                .ForMember(x => x.Availability, y => y.MapFrom(z => z.Availability));

            this.CreateMap<Car, API.Domain.Models.Car>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Brand, y => y.MapFrom(z => z.Brand))
                .ForMember(x => x.Model, y => y.MapFrom(z => z.Model))
                .ForMember(x => x.YearOfProduction, y => y.MapFrom(z => z.YearOfProduction));
        }
    }
}
