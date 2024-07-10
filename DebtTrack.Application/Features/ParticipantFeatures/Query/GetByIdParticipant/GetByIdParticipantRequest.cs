using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record GetByIdParticipantRequest 
    (
        int ParticipantId
    ): IRequest<GetByIdParticipantResponse>;