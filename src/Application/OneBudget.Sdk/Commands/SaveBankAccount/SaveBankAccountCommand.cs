using System.Threading.Tasks;

using OneBudget.Model;
using OneBudget.Model.Common;
using OneBudget.Model.Common.Mapping;
using OneBudget.Sdk.Persistence;

namespace OneBudget.Sdk.Commands
{
    public class SaveBankAccountCommand : ISaveBankAccountCommand
    {
        private readonly IBudgetRepository _budgetRepository;

        public SaveBankAccountCommand(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public async Task Execute(SaveBankAccountModel model)
        {
            BankAccount bankAccount = EntityMapper.Map<SaveBankAccountModel, BankAccount>(model);
            Budget budget = await _budgetRepository.Get(model.BudgetId);

            budget.BankAccounts.Upsert(bankAccount);

            await _budgetRepository.Save(budget);
        }
    }
}
