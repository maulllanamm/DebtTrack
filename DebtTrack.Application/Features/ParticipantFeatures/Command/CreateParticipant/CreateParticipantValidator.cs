using FluentValidation;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public class CreateParticipantValidator : AbstractValidator<CreateParticipantRequest>
{
    public CreateParticipantValidator()
    {
        RuleFor(x => x.Nama).NotEmpty();
        RuleFor(x => x.Divisi).NotEmpty();
        RuleFor(x => x.Panggilan).NotEmpty();
    }
}