using CarRental.ApplicationServices.API.Domain.CarsReqAndResp;
using FluentValidation;

namespace CarRental.ApplicationServices.API.Validators
{
    public class AddCarRequestValidator : AbstractValidator<AddCarRequest>
    {
        public AddCarRequestValidator()
        {
            this.RuleFor(x => x.Brand).Length(1, 50);
        }
    }
}
