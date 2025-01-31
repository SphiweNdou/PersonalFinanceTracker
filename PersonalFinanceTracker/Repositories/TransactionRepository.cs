namespace PersonalFinanceTracker.Repositories
{
    using PersonalFinanceTracker.Data;
    using PersonalFinanceTracker.Models;
    using Microsoft.EntityFrameworkCore;
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(ApplicationDbContext context) : base(context) 
        {
        }

        public async Task<IEnumerable<Transaction>> GetUserTransactionAsync(int userId) 
        {
            return await _dbSet.Where(t => t.UserId == userId).ToListAsync();
        }
    }
}
