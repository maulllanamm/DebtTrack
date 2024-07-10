namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record GetAllParticipantResponse
    (
        string Nama,
        string Divisi,
        string Panggilan
    );
    