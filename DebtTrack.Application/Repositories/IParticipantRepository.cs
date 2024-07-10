using DebtTrack.Domain.Entities;

namespace DebtTrack.Application.Repositories;

public interface IParticipantRepository
{
    public Task<List<Participant>> GetAll();
    public Task<Participant> GetById(int participantId);
    public Task<Participant> Create(Participant participant);
    public Task<Participant> Update(Participant participant);
}