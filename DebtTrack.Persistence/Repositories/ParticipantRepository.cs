using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using DebtTrack.Persistence.Context;

namespace DebtTrack.Persistence.Repositories
{
    public class ParticipantRepository : BaseRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(DataContext context) : base(context)
        {
        }

    }
}
