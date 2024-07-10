using DebtTrack.Domain.Entities;

namespace DebtTrack.Application.Repositories;

public interface IParticipantRepository
{
    public Task<Participant> Create(Participant participant);
    public Task<List<Participant>> GetAll();
    public Task<Participant> GetById(int participantId);
}