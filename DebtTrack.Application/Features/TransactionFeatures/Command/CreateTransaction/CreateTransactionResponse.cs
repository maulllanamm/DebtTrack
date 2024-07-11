namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public sealed record CreateTransactionResponse
{
    public int ActivityId { get; init; }
    public int ParticipantId { get; init; }
    public string Amount { get; init; }
    public string Description { get; init; }
    public bool IsPaid { get; init; }
}