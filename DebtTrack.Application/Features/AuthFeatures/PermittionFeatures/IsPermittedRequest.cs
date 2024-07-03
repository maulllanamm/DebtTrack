using DebtTrack.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace DebtTrack.Application.Features.AuthFeatures.PermittionFeatures
{
    public sealed record IsPermittedRequest
    (
        HttpContext HttpContext,
        Role? role
    ) : IRequest<bool>;

}
