namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record DeleteParticipantResponse
    (
        string Nama,
        string Divisi,
        string Panggilan
    );
    