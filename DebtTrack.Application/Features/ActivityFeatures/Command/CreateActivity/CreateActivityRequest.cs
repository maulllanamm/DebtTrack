using MediatR;

namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public sealed record CreateActivityRequest
    (
        string Activity,
        string Place,
        string Debtor,
        DateTimeOffset ActivityDate,
        double Bill,
        double Tax
    ): IRequest<CreateActivityResponse>;