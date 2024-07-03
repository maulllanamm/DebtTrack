using MediatR;

namespace DebtTrack.Application.Features.UserFeatures.Query.GetAll
{
    public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>
    {

    }
}
