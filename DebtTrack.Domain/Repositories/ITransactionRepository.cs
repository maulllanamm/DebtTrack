using DebtTrack.Domain.Entities;

namespace DebtTrack.Application.Repositories;

public interface ITransactionRepository
{
    public Task<List<Transaction>> GetAll();
    public Task<List<Transaction>> GetByActivityId(int activityId);
    public Task<Transaction> Create(Transaction transaction);
    public Task<int> UpdateBulk(List<Transaction> transactions);

}