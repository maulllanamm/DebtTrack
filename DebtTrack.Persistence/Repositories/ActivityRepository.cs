using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using DebtTrack.Persistence.Context;

namespace DebtTrack.Persistence.Repositories
{
    public class ActivityRepository : BaseRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(DataContext context) : base(context)
        {
        }

    }
}
