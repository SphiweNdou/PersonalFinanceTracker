namespace PersonalFinanceTracker.Repositories
{
    using PersonalFinanceTracker.Data;
    using PersonalFinanceTracker.Models;

    public class UnitOfWork :IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ITransactionRepository Transactions { get; }
        public IRepository<ApplicationUser> Users { get; }
        public IAccountRepository AccountRepository { get; }

        public UnitOfWork(ApplicationDbContext context, ITransactionRepository transactions, IRepository<ApplicationUser> users, IAccountRepository accounts)
        {
            _context = context;
            Transactions = transactions;
            AccountRepository = accounts;
            Users = users;
        }
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
