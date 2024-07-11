namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public sealed record CreateActivityResponse
    (
        string Activity,
        string Place,
        string Debtor,
        DateTimeOffset ActivityDate,
        double Bill,
        double Tax,
        double TotalBill
    );
    