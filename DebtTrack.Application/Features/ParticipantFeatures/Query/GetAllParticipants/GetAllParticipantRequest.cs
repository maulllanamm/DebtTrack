using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public sealed record GetAllParticipantRequest: IRequest<List<GetAllParticipantResponse>>;