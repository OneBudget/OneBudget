using System.Threading.Tasks;

using OneBudget.Model;
using OneBudget.Model.Common;
using OneBudget.Model.Common.Mapping;
using OneBudget.Sdk.Persistence;

namespace OneBudget.Sdk.Commands
{
    public class SaveBudgetAllocationCommand : ISaveBudgetAllocationCommand
    {
        private readonly IBudgetAllocationRepository _budgetAllocationRepository;
        private readonly IBudgetRepository _budgetRepository;

        public SaveBudgetAllocationCommand(
            IBudgetAllocationRepository budgetAllocationRepository,
            IBudgetRepository budgetRepository
            )
        {
            _budgetAllocationRepository = budgetAllocationRepository;
            _budgetRepository = budgetRepository;
        }

        public async Task Execute(SaveBudgetAllocationModel model)
        {
            Budget budget = await _budgetRepository.Get(model.BudgetId);
            Category category = budget.Categories.GetById(model.CategoryId);

            BudgetAllocation allocation = EntityMapper.Map<SaveBudgetAllocationModel, BudgetAllocation>(model);
            allocation.Budget = budget;
            allocation.Category = category;

            await _budgetAllocationRepository.Save(allocation);
        }
    }
}
