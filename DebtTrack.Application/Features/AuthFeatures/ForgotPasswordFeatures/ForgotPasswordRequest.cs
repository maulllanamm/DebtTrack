using MediatR;

namespace DebtTrack.Application.Features.AuthFeatures.ForgotPasswordFeatures
{
    public sealed record ForgotPasswordRequest
    (
        string Email
    ) : IRequest<string>;
}
