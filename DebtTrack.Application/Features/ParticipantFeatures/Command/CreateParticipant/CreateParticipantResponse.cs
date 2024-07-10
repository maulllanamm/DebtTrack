namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record CreateParticipantResponse
    (
        string Nama,
        string Divisi,
        string Panggilan
    );
    