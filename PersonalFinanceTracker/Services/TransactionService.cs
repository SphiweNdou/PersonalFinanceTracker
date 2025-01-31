namespace PersonalFinanceTracker.Services
{
    using PersonalFinanceTracker.Models;
    using PersonalFinanceTracker.Repositories;
    public class TransactionService :ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactionsAsync()
        {
            return await _unitOfWork.Transactions.GetAllAsync();
        }

        public async Task<Transaction?> GetTransactionByIdAsync(int id)
        {
            return await _unitOfWork.Transactions.GetByIdAsync(id); 
        }

        public async Task AddTransactionAsync(Transaction transaction)
        {
            await _unitOfWork.Transactions.AddAsync(transaction);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<bool> UpdateTransactionAsync(Transaction transaction)
        {
            var existingTransaction = await _unitOfWork.Transactions.GetByIdAsync(transaction.Id);
            if (existingTransaction == null) return false;

            existingTransaction.Amount = transaction.Amount;
            existingTransaction.Description = transaction.Description;
            existingTransaction.Date = transaction.Date;
            existingTransaction.Catergory = transaction.Catergory;

            await _unitOfWork.Transactions.UpdateAsync(existingTransaction);
            await _unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<bool> DeleteTransactionAsync(int id)
        {
            var transaction = await _unitOfWork.Transactions.GetByIdAsync(id);
            if (transaction == null) return false;
            await _unitOfWork.Transactions.RemoveAsync(transaction);
            await _unitOfWork.CompleteAsync();
            return true;
        }
    }
}
