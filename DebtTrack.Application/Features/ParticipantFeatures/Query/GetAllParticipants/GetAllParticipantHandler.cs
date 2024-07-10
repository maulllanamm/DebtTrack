using AutoMapper;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public class GetAllParticipantHandler : IRequestHandler<GetAllParticipantRequest,List<GetAllParticipantResponse>>
{
    private readonly IMapper _mapper;
    private readonly IParticipantRepository _participantRepository;
    
    public GetAllParticipantHandler(IParticipantRepository participantRepository, IMapper mapper)
    {
        _participantRepository = participantRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllParticipantResponse>> Handle(GetAllParticipantRequest request, CancellationToken cancellationToken)
    {
        var res = await _participantRepository.GetAll();
        return _mapper.Map<List<GetAllParticipantResponse>>(res);
    }
}