using PersonalFinanceTracker.Models;

namespace PersonalFinanceTracker.Services
{
    public interface IAccountServices
    {
        Task<IEnumerable<Account>> GetAllAccountsAsync();
        Task<Account> GetAccountByIdAsync(int id);
        Task CreateAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task DeleteAccountAsync(int id);
        
    }
}
