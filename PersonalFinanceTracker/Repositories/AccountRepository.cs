using PersonalFinanceTracker.Data;
using PersonalFinanceTracker.Models;

namespace PersonalFinanceTracker.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        public AccountRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Taks<Account> FindAsync(int id)
        {
            return await _context.Accounts.FindAsync(id);
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
    }
}
