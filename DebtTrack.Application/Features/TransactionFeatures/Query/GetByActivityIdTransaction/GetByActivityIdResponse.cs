namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public sealed record GetByActivityIdResponse
    (
        int Id,
        int ParticipantId,
        int ActivityId,
        int Amount,
        decimal? TotalAmountToBePaid,
        string Description,
        bool IsPaid
    );
    