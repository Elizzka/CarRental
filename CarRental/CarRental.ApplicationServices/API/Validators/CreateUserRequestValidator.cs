using CarRental.ApplicationServices.API.Domain.UserReqAndResp;
using FluentValidation;

namespace CarRental.ApplicationServices.API.Validators
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator() 
        {
            this.RuleFor(x => x.Password).Length(4, 30);
        }
    }
}
