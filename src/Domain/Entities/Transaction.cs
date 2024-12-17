namespace Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string Description { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime Date { get; private set; }
        public TransactionType Type { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }

        public Transaction(string description, decimal amount, DateTime date, TransactionType type, int categoryId, Category category)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than 0");
            }
            Id = Guid.NewGuid();
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Amount = amount;
            Date = date;
            Type = type;
            CategoryId = categoryId;
            Category = category ?? throw new ArgumentNullException(nameof(category));
        }

    }
}
