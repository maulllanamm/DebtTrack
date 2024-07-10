using AutoMapper;
using DebtTrack.Application.Common.Exceptions;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public class UpdateParticipantHandler : IRequestHandler<UpdateParticipantRequest,UpdateParticipantResponse>
{
    private readonly IMapper _mapper;
    private readonly IParticipantRepository _participantRepository;
    
    public UpdateParticipantHandler(IParticipantRepository participantRepository, IMapper mapper)
    {
        _participantRepository = participantRepository;
        _mapper = mapper;
    }

    public async Task<UpdateParticipantResponse> Handle(UpdateParticipantRequest request, CancellationToken cancellationToken)
    {
        var participant = await _participantRepository.GetById(request.Id);
        if (participant is null)
        {
            throw new NotFoundException($"Participant id {request.Id} not found");
        }

        participant.nama = request.Nama;
        participant.divisi = request.Divisi;
        participant.panggilan = request.Panggilan;
        participant.modified_date = DateTime.UtcNow;
        
        var res = await _participantRepository.Update(participant);
        return _mapper.Map<UpdateParticipantResponse>(res);
    }
}