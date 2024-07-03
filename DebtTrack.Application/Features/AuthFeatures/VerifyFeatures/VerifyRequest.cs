﻿using MediatR;

namespace DebtTrack.Application.Features.AuthFeatures.VerifyFeatures
{
    public sealed record VerifyRequest
    (
        string VerifyToken
    ) : IRequest<string>;
}
