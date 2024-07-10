using AutoMapper;
using DebtTrack.Application.Common.Exceptions;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public class GetByIdParticipantHandler : IRequestHandler<GetByIdParticipantRequest,GetByIdParticipantResponse>
{
    private readonly IMapper _mapper;
    private readonly IParticipantRepository _participantRepository;
    
    public GetByIdParticipantHandler(IParticipantRepository participantRepository, IMapper mapper)
    {
        _participantRepository = participantRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdParticipantResponse> Handle(GetByIdParticipantRequest request, CancellationToken cancellationToken)
    {
        var res = await _participantRepository.GetById(request.ParticipantId);
        if (res is null)
        {
            throw new NotFoundException($"Participant id {request.ParticipantId} not found");
        }
        return _mapper.Map<GetByIdParticipantResponse>(res);
    }
}