namespace PersonalFinanceTracker.Services
{
    using PersonalFinanceTracker.Models;
    public interface ITransactionService
    {
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync();
        Task<Transaction> GetTransactionByIdAsync(int id);
        Task AddTransactionAsync(Transaction transaction);
        Task<bool> DeleteTransactionAsync(int id);
        Task<bool> UpdateTransactionAsync(Transaction transaction);
    }
}
