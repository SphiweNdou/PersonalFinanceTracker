using PersonalFinanceTracker.Models;
using PersonalFinanceTracker.Repositories;

namespace PersonalFinanceTracker.Services
{
    public class AccountService : IAccountServices
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService (IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await _accountRepository.GetAllAsync(); 
        }

        public async Task<Account> GetAccountByIdAsync(int id)
        {
            return await _accountRepository.GetByIdAsync(id);
        }

        public async Task CreateAccountAsync(Account account)
        {
            _accountRepository.AddAsync(account);
        }

        public async Task UpdateAccountAsync(Account account)
        {
            _accountRepository.UpdateAsync(account);
        }

        public async Task DeleteAccountAsync(int id)
        {
            await _accountRepository.DeleteAsync(id);
        }
    }
}
