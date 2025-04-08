using CarRental.ApplicationServices.API.Domain.CustomerReqAndResp;
using FluentValidation;

namespace CarRental.ApplicationServices.API.Validators
{
    public class AddCustomerRequestValidator : AbstractValidator<AddCustomerRequest>
    {
        public AddCustomerRequestValidator()
        {
            this.RuleFor(x => x.Name).Length(1, 50);
            this.RuleFor(x => x.Surname).Length(1, 50);
        }
    }
}
