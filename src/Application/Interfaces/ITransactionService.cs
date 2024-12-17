using Domain.Entities;
using Domain.Enums;

namespace Application.Interfaces
{
    public interface ITransactionService
    {
        void AddTransaction(string description, decimal amount, DateTime date, TransactionType type, int categoryId, Category category);
        List<Transaction> GetTransactions();
        decimal GetTotalExpenses();
        decimal GetTotalIncome();
    }
}
