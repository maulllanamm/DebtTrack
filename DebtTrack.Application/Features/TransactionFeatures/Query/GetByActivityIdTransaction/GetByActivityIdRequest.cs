using MediatR;

namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public sealed record GetByActivityIdRequest 
    (
        int ActivityId
    ): IRequest<List<GetByActivityIdResponse>>;