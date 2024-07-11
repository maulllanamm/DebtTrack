namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public sealed record CalculateTotalAmountToBePaidResponse
{
    public int ParticipantId { get; init; }
    public string TotalAmountToBePaid { get; init; }
}