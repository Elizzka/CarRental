using AutoMapper;
using CarRental.ApplicationServices.API.Domain.RentalDataReqAndResp;
using CarRental.DataAccess.Entities;

namespace CarRental.ApplicationServices.Mappings
{
    public class RentalsDataProfile : Profile
    {
        public RentalsDataProfile()
        {
            this.CreateMap<UpdateRentalDataRequest, RentalData>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.CarId, y => y.MapFrom(z => z.CarId))
                .ForMember(x => x.PricePerDay, y => y.MapFrom(z => z.PricePerDay))
                .ForMember(x => x.NumberOfDays, y => y.MapFrom(z => z.NumberOfDays));

            this.CreateMap<RentalData, API.Domain.Models.RentalData>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.CarId, y => y.MapFrom(z => z.CarId))
                .ForMember(x => x.PricePerDay, y => y.MapFrom(z => z.PricePerDay))
                .ForMember(x => x.NumberOfDays, y => y.MapFrom(z => z.NumberOfDays));
        }
    }
}
