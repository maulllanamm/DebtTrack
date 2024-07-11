using MediatR;

namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public sealed record CalculateTotalAmountToBePaidRequest
(
    int ActivityId
) : IRequest<List<CalculateTotalAmountToBePaidResponse>>;
