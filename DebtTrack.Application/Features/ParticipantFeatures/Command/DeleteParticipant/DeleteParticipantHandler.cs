using AutoMapper;
using DebtTrack.Application.Common.Exceptions;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public class DeleteParticipantHandler : IRequestHandler<DeleteParticipantRequest,bool>
{
    private readonly IMapper _mapper;
    private readonly IParticipantRepository _participantRepository;
    
    public DeleteParticipantHandler(IParticipantRepository participantRepository, IMapper mapper)
    {
        _participantRepository = participantRepository;
        _mapper = mapper;
    }

    public async Task<bool> Handle(DeleteParticipantRequest request, CancellationToken cancellationToken)
    {
        var participant = await _participantRepository.Delete(request.Id);
        if (!participant)
        {
            throw new NotFoundException($"Participant id {request.Id} not found");
        }
        return participant;
    }
}