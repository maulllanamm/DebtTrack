using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record GetAllTransactionRequest: IRequest<List<GetAllTransactionResponse>>;