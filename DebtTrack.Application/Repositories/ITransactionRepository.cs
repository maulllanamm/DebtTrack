using DebtTrack.Domain.Entities;

namespace DebtTrack.Application.Repositories;

public interface ITransactionRepository
{
    public Task<Transaction> Create(Transaction transaction);
    public Task<List<Transaction>> GetByActivityId(int activityId);
    public Task<int> UpdateBulk(List<Transaction> transactions);

}