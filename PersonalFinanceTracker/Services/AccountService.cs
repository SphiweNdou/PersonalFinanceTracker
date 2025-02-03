namespace PersonalFinanceTracker.Services
{
    using PersonalFinanceTracker.Models;
    using PersonalFinanceTracker.Repositories;
    public class AccountService : IAccountServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public AccountService ( IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }

        public async Task<IEnumerable<Account>> GetAllAccountsAsync()
        {
            return await _unitOfWork.Accounts.GetAllAsync(); 
        }

        public async Task<Account> GetAccountByIdAsync(int id)
        {
            return await _unitOfWork.Accounts.GetByIdAsync(id);
        }

        public async Task CreateAccountAsync(Account account)
        {
            await _unitOfWork.Accounts.CreateAsync(account);
            await _unitOfWork.CompleteAsync();
        }

        public async Task UpdateAccountAsync(Account account)
        {
            await _unitOfWork.Accounts.UpdateAsync(account);
            await _unitOfWork.CompleteAsync();
        }

        public async Task DeleteAccountAsync(int id)
        {
            await _unitOfWork.Accounts.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();
        }

    }
}
