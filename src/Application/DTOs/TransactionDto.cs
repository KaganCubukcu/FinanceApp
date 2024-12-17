using Domain.Enums;

namespace Application.DTOs
{
    public class TransactionDto
    {
        public Guid Id { get; set; }
        public required string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public int CategoryId { get; set; }
    }
}
