using FluentValidation;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public class UpdateParticipantValidator : AbstractValidator<UpdateParticipantRequest>
{
    public UpdateParticipantValidator()
    {
        RuleFor(x => x.Nama).NotEmpty();
        RuleFor(x => x.Divisi).NotEmpty();
        RuleFor(x => x.Panggilan).NotEmpty();
    }
}