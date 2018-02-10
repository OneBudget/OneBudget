using System;
using System.Threading.Tasks;

using OneBudget.Sdk.Persistence;

namespace OneBudget.Sdk.Commands
{
    public class SaveBankAccountCommand : ISaveBankAccountCommand
    {
        private readonly IBankAccountRepository _bankAccountRepository;

        public SaveBankAccountCommand(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }

        public async Task Execute(SaveBankAccountModel model)
        {
            throw new NotImplementedException();
        }
    }
}
