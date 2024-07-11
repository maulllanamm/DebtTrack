namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public sealed record GetByIdActivityResponse
    (
        string Activity,
        string Place,
        string Debtor,
        DateTimeOffset ActivityDate,
        decimal Bill,
        decimal Tax,
        decimal TotalBill,
        bool? IsDeleted,
        DateTimeOffset? CreatedDate,
        string CreatedBy ,
        DateTimeOffset? ModifiedDate,
        string ModifiedBy 
    );
    