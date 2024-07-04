namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public sealed record CreateTransactionResponse
{
    public string Amount { get; init; }
    public string Description { get; init; }
    public string IsPaid { get; init; }
}