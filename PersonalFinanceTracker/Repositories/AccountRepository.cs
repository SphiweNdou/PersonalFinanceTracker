namespace PersonalFinanceTracker.Repositories
{
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;
    using PersonalFinanceTracker.Data;
    using PersonalFinanceTracker.Models;

    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        protected readonly DbSet<Account> _dbSet;
        public AccountRepository (ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Account>();
        }

        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            return await _context.Accounts.ToListAsync();
        }

        
        public async Task UpdateAsync(Account account)
        {
             _context.Accounts.Update(account);
        }

        public async Task DeleteAsync(int id)
        {
            var account = await _context.Accounts.FindAsync(id);

            if(account != null)
            {
                _context.Accounts.Remove(account);
            }
        }

        public async Task<Account> GetByIdAsync(int id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task CreateAsync(Account account)
        {
            await _context.Accounts.AddAsync(account);
        }
    }
}
