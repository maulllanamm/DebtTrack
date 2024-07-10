using AutoMapper;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public class CreateParticipantHandler : IRequestHandler<CreateParticipantRequest,CreateParticipantResponse>
{
    private readonly IMapper _mapper;
    private readonly IParticipantRepository _participantRepository;
    
    public CreateParticipantHandler(IParticipantRepository participantRepository, IMapper mapper)
    {
        _participantRepository = participantRepository;
        _mapper = mapper;
    }

    public async Task<CreateParticipantResponse> Handle(CreateParticipantRequest request, CancellationToken cancellationToken)
    {
        var participant = _mapper.Map<Participant>(request);
        var res = await _participantRepository.Create(participant);
        return _mapper.Map<CreateParticipantResponse>(res);
    }
}