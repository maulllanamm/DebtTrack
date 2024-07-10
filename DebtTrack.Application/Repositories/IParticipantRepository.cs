using DebtTrack.Domain.Entities;

namespace DebtTrack.Application.Repositories;

public interface IParticipantRepository
{
    public Task<Participant> Create(Participant participant);
}