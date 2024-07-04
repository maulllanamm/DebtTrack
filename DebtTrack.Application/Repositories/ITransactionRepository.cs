using DebtTrack.Domain.Entities;

namespace DebtTrack.Application.Repositories;

public interface ITransactionRepository
{
    public Task<Transaction> Create(Transaction transaction);
}