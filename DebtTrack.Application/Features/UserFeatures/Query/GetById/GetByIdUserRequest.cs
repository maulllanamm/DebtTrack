using MediatR;

namespace DebtTrack.Application.Features.UserFeatures.Query.GetById
{
    public sealed record GetByIdUserRequest(int id) : IRequest<GetByIdUserResponse>;
}
