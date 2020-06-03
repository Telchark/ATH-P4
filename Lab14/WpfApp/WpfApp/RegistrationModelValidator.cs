using FluentValidation;

namespace WpfApp
{
    public class RegistrationModelValidator : AbstractValidator<RegistrationModel>
    {
       public RegistrationModelValidator()
        {
            this.CascadeMode = CascadeMode.StopOnFirstFailure;
            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress();

            RuleFor<string>(x => x.Password)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6)
                .Must(y => !(y == y.ToLower() || y == y.ToUpper()));

            RuleFor<bool>(x => x.Accept)
                .Must(x => x)
                .WithMessage("Musisz wyrazić zgodę.");
        }
    }
}
