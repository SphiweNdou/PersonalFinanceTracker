namespace PersonalFinanceTracker.Repositories
{
    using System.Linq.Expressions;
    public interface IRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        /*
         * Query any model 'T' with predicate being the 'where' clause
         * Expression is used so that the linq 'predicate' can be converted into sql for entity framework
         */
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);  
    }
}
