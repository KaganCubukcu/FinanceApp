namespace Domain.Entities
{
    public class Budget
    {
        public decimal TotalAmount { get; private set; }

        public Budget(decimal totalAmount)
        {
            if (totalAmount <= 0)
            {
                throw new ArgumentException("Total amount must be greater than 0");
            }
            TotalAmount = totalAmount;
        }

        public decimal GetRemainingAmount(List<Transaction> transactions)
        {
           var totalExpenses = transactions.Where(t => t.Type == TransactionType.Expense).Sum(t => t.Amount);
           
           return TotalAmount - totalExpenses;
        }

        public decimal GetBudgetUtilizationPercentage(List<Transaction> transactions)
        {
            var totalExpenses = transactions.Where(t => t.Type == TransactionType.Expense).Sum(t => t.Amount);
            return TotalAmount > 0 ? (totalExpenses / TotalAmount) * 100 : 0;
        }
    }
}
