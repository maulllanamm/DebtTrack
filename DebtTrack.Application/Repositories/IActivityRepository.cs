using DebtTrack.Domain.Entities;

namespace DebtTrack.Application.Repositories;

public interface IActivityRepository
{
    public Task<Activity> Create(Activity activity);
    public Task<Activity> GetById(int activityId);
}