using System;
using System.Threading.Tasks;

namespace OneBudget.Sdk.Queries
{
    public interface IGetBudgetQuery
    {
        Task<GetBudgetModel> Execute(Guid budgetId);
    }
}
