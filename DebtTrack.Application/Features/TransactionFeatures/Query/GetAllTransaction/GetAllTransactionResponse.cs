namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record GetAllTransactionResponse
    (
        int ActivityId,
        int ParticipantId,
        decimal Amount,
        string Description,
        decimal TotalAmountToBePaid,
        bool IsPaid,
        bool? IsDeleted,
        DateTimeOffset? CreatedDate,
        string CreatedBy ,
        DateTimeOffset? ModifiedDate,
        string ModifiedBy 
    );
