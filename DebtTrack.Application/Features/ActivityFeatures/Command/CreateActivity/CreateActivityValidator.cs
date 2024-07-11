using FluentValidation;

namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public class CreateActivityValidator : AbstractValidator<CreateActivityRequest>
{
    public CreateActivityValidator()
    {
        RuleFor(x => x.Activity).NotEmpty();
        RuleFor(x => x.Place).NotEmpty();
        RuleFor(x => x.Debtor).NotEmpty();
        RuleFor(x => x.Bill).GreaterThan(0).WithMessage("Bill must be greater than 0.").NotNull();
    }
}