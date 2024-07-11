using AutoMapper;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public class CreateActivityHandler : IRequestHandler<CreateActivityRequest,CreateActivityResponse>
{
    private readonly IMapper _mapper;
    private readonly IActivityRepository _ActivityRepository;
    
    public CreateActivityHandler(IActivityRepository activityRepository, IMapper mapper)
    {
        _ActivityRepository = activityRepository;
        _mapper = mapper;
    }

    public async Task<CreateActivityResponse> Handle(CreateActivityRequest request, CancellationToken cancellationToken)
    {
        var activity = _mapper.Map<Activity>(request);
        activity.total_bill = activity.bill + (activity.bill * activity.tax);
        var res = await _ActivityRepository.Create(activity);
        return _mapper.Map<CreateActivityResponse>(res);
    }
}