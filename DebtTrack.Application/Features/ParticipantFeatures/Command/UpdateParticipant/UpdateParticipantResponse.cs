namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record UpdateParticipantResponse
    (
        string Nama,
        string Divisi,
        string Panggilan
    );
    