using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record CreateParticipantRequest
    (
        string Nama,
        string Divisi,
        string Panggilan
    ): IRequest<CreateParticipantResponse>;