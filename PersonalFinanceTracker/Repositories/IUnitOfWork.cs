using PersonalFinanceTracker.Models;

namespace PersonalFinanceTracker.Repositories
{
    public interface IUnitOfWork
    {
        ITransactionRepository Transactions { get; }
        IRepository<ApplicationUser> Users { get; }
        IAccountRepository Accounts { get; }
        Task<int> CompleteAsync();
    }
}
