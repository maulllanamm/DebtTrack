using MediatR;

namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public sealed record GetByIdActivityRequest 
    (
        int ActivityId
    ): IRequest<GetByIdActivityResponse>;