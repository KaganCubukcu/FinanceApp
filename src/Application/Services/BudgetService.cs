using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class BudgetService : IBudgetService
    {
        private readonly ITransactionService _transactionService;

        public BudgetService(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        public decimal GetRemainingAmount(Budget budget)
        {
            return budget.GetRemainingAmount(_transactionService.GetTransactions());
        }
        public decimal GetBudgetUtilizationPercentage(Budget budget)
        {
            return budget.GetBudgetUtilizationPercentage(_transactionService.GetTransactions());
        }
    }
}