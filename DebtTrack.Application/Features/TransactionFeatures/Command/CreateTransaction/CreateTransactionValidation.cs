using FluentValidation;

namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public class CreateTransactionValidation : AbstractValidator<CreateTransactionRequest>
{
    public CreateTransactionValidation()
    {
        RuleFor(x => x.Amount).NotEmpty().WithMessage("Amount is required");
        RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
    }
}