using FluentValidation;

namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public class CalculateTotalAmountToBePaidValidation : AbstractValidator<CalculateTotalAmountToBePaidRequest>
{
    public CalculateTotalAmountToBePaidValidation()
    {
        RuleFor(x => x.ActivityId).NotEmpty().WithMessage("ActivityId is required");
    }
}