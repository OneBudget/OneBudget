using System.Threading.Tasks;

using AutoMapper;

using OneBudget.Model;
using OneBudget.Model.Common;
using OneBudget.Sdk.Persistence;

namespace OneBudget.Sdk.Commands
{
    public class SaveBudgetAllocationCommand : ISaveBudgetAllocationCommand
    {
        private readonly IBudgetAllocationRepository _budgetAllocationRepository;
        private readonly IBudgetRepository _budgetRepository;
        private readonly IMapper _mapper;

        public SaveBudgetAllocationCommand(
            IBudgetAllocationRepository budgetAllocationRepository,
            IBudgetRepository budgetRepository,
            IMapper mapper
            )
        {
            _budgetAllocationRepository = budgetAllocationRepository;
            _budgetRepository = budgetRepository;
            _mapper = mapper;
        }

        public async Task Execute(SaveBudgetAllocationModel model)
        {
            Budget budget = await _budgetRepository.Get(model.BudgetId);
            Category category = budget.Categories.GetById(model.CategoryId);

            BudgetAllocation allocation = _mapper.Map<BudgetAllocation>(model);
            allocation.Budget = budget;
            allocation.Category = category;

            await _budgetAllocationRepository.Save(allocation);
        }
    }
}
