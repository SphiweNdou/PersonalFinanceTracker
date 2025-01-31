namespace PersonalFinanceTracker.Repositories
{
    using PersonalFinanceTracker.Models;
    public interface ITransactionRepository : IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetUserTransactionAsync(int userId);
    }
}
