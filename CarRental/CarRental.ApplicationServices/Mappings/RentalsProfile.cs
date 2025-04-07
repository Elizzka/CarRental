using AutoMapper;
using CarRental.DataAccess.Entities;
using CarRental.ApplicationServices.API.Domain.RentalReqAndResp;

namespace CarRental.ApplicationServices.Mappings
{
    public class RentalsProfile : Profile
    {
        public RentalsProfile()
        {  
            this.CreateMap<UpdateRentalRequest, Rental>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.RentalDate, y => y.MapFrom(z => z.RentalDate))
                .ForMember(x => x.ReturnDate, y => y.MapFrom(z => z.ReturnDate))
                .ForMember(x => x.CustomerId, y => y.MapFrom(z => z.CustomerId))
                .ForMember(x => x.CustomerId, y => y.MapFrom(z => z.CustomerId));
            
            this.CreateMap<Rental, API.Domain.Models.Rental>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.RentalDate, y => y.MapFrom(z => z.RentalDate))
                .ForMember(x => x.ReturnDate, y => y.MapFrom(z => z.ReturnDate))
                .ForMember(x => x.CustomerId, y => y.MapFrom(z => z.CustomerId));
        }
    }
}
