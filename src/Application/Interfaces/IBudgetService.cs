using Domain.Entities;

namespace Application.Services
{
    public interface IBudgetService
    {
        decimal GetRemainingAmount(Budget budget);
        decimal GetBudgetUtilizationPercentage(Budget budget);
    }
}
