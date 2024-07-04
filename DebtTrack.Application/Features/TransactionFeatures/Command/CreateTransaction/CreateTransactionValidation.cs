using FluentValidation;

namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public class CreateTransactionValidation : AbstractValidator<CreateTransactionRequest>
{
    public CreateTransactionValidation()
    {
        RuleFor(x => x.Amount).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
    }
}