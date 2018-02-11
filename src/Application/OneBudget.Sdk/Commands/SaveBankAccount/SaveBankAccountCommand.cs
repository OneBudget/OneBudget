using System.Threading.Tasks;

using AutoMapper;

using OneBudget.Model;
using OneBudget.Model.Common;
using OneBudget.Sdk.Persistence;

namespace OneBudget.Sdk.Commands
{
    public class SaveBankAccountCommand : ISaveBankAccountCommand
    {
        private readonly IBudgetRepository _budgetRepository;
        private readonly IMapper _mapper;

        public SaveBankAccountCommand(IBudgetRepository budgetRepository, IMapper mapper)
        {
            _budgetRepository = budgetRepository;
            _mapper = mapper;
        }

        public async Task Execute(SaveBankAccountModel model)
        {
            BankAccount bankAccount = _mapper.Map<BankAccount>(model);
            Budget budget = await _budgetRepository.Get(model.BudgetId);

            budget.BankAccounts.Upsert(bankAccount);

            await _budgetRepository.Save(budget);
        }
    }
}
