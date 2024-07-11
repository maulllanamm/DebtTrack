using MediatR;

namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public sealed record CreateTransactionRequest
(
    int ActivityId,
    int ParticipantId,
    decimal Amount,
    string Description
) : IRequest<CreateTransactionResponse>;
