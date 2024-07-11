namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public sealed record GetByIdActivityResponse
    (
        string Nama,
        string Divisi,
        string Panggilan
    );
    