namespace PersonalFinanceTracker.Controllers
{
    using PersonalFinanceTracker.Models;
    using PersonalFinanceTracker.Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTransactions()
        {
            var transaction = await _transactionService.GetAllTransactionsAsync();
            return Ok(transaction);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetTransaction(int id)
        {
            var transaction = await _transactionService.GetTransactionByIdAsync(id);
            if (transaction == null) return NotFound();
            return Ok(transaction);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransaction(Transaction transaction)
        {
            await _transactionService.AddTransactionAsync(transaction);
            return CreatedAtAction(nameof(GetTransaction), new {id = transaction.Id}, transaction);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTransaction(int id, Transaction transaction)
        {
            if (id != transaction.Id) return BadRequest("Transaction ID mismmatch");
            var updated = await _transactionService.UpdateTransactionAsync(transaction);
            
            if(!updated) return NotFound(); 

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransaction(int id)
        {
            var deleted = await _transactionService.DeleteTransactionAsync(id);
            if(!deleted) return NotFound();
            return NoContent();
        }
    }
}
