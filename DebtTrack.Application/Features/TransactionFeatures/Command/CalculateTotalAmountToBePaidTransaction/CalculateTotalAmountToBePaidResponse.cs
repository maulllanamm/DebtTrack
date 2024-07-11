namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public sealed record CalculateTotalAmountToBePaidResponse
{
    public int ParticipantId { get; init; }
    public decimal TotalAmountToBePaid { get; init; }
}