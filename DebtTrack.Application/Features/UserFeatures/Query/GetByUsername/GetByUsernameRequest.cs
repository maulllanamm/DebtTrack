using MediatR;

namespace DebtTrack.Application.Features.UserFeatures.Query.GetByUsername
{
    public sealed record GetByUsernameRequest
    (
        string Username    
    ) : IRequest<GetByUsernameResponse>;
}
