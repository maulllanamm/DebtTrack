using AutoMapper;
using DebtTrack.Application.Common.Exceptions;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public class GetByIdActivityHandler : IRequestHandler<GetByIdActivityRequest,GetByIdActivityResponse>
{
    private readonly IMapper _mapper;
    private readonly IActivityRepository _activityRepository;
    
    public GetByIdActivityHandler(IActivityRepository activityRepository, IMapper mapper)
    {
        _activityRepository = activityRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdActivityResponse> Handle(GetByIdActivityRequest request, CancellationToken cancellationToken)
    {
        var res = await _activityRepository.GetById(request.ActivityId);
        if (res is null)
        {
            throw new NotFoundException($"Activity id {request.ActivityId} not found");
        }
        return _mapper.Map<GetByIdActivityResponse>(res);
    }
}