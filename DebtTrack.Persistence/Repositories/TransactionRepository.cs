using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using DebtTrack.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DebtTrack.Persistence.Repositories;

public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
{
    public TransactionRepository(DataContext context) : base(context)
    {   
    }
    public async Task<List<Transaction>> GetByActivityId(int activityId)
    {
        return await _context.Transactions.Where(x => x.activity_id == activityId).ToListAsync();
    }
}