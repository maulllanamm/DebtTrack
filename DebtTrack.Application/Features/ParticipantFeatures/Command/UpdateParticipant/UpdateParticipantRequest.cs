using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record UpdateParticipantRequest
    (
        int Id,
        string Nama,
        string Divisi,
        string Panggilan
    ): IRequest<UpdateParticipantResponse>;