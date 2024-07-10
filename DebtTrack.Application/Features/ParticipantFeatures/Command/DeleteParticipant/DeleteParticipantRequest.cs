using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record DeleteParticipantRequest
    (
        int Id
    ): IRequest<bool>;