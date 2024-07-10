namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record GetByIdParticipantResponse
    (
        string Nama,
        string Divisi,
        string Panggilan
    );
    