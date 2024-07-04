using MediatR;

namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public sealed record CreateTransactionRequest
(
    int DebtorId,
    int CreditorId,
    decimal Amount,
    string Description
) : IRequest<CreateTransactionResponse>;
