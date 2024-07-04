using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using DebtTrack.Persistence.Context;

namespace DebtTrack.Persistence.Repositories;

public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
{
    public TransactionRepository(DataContext context) : base(context)
    {   
    }

}