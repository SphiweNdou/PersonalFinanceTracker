using PersonalFinanceTracker.Models;

namespace PersonalFinanceTracker.Services
{
    public interface IAccountServices
    {
        Task<IEnumerable<Account>> GertAllAcountsAsync();
        Task<Account> GetAccountByIdAsync(int id);
        Task CreateAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task DeleteAccountAsync(Account account);
        
    }
}
