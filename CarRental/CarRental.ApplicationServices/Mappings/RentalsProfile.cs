using AutoMapper;
using CarRental.ApplicationServices.API.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.ApplicationServices.Mappings
{
    public class RentalsProfile : Profile
    {
        public RentalsProfile()
        {
            this.CreateMap<DataAccess.Entities.Rental, Rental>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.RentalDate, y => y.MapFrom(z => z.RentalDate))
                .ForMember(x => x.ReturnDate, y => y.MapFrom(z => z.ReturnDate))
                .ForMember(x => x.CustomerId, y => y.MapFrom(z => z.CustomerId));
        }
    }
}
