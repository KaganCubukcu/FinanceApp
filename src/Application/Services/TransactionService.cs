using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly List<Transaction> _transactions = new List<Transaction>();
        private decimal _totalExpenses = 0;
        private decimal _totalIncome = 0;

        public void AddTransaction(string description, decimal amount, DateTime date, TransactionType type, int categoryId, Category category)
        {
            _transactions.Add(new Transaction(description, amount, date, type, categoryId, category));

            if (type == TransactionType.Expense)
            {
                _totalExpenses += amount;
            }
            else if (type == TransactionType.Income)
            {
                _totalIncome += amount;
            }
        }
        public List<Transaction> GetTransactions()
        {
            return new List<Transaction>(_transactions);
        }
        public decimal GetTotalExpenses()
        {
            return _totalExpenses;
        }
        public decimal GetTotalIncome()
        {
            return _totalIncome;
        }
    }
}
