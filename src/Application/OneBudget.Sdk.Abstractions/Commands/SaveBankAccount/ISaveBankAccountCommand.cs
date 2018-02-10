using System.Threading.Tasks;

namespace OneBudget.Sdk.Commands
{
    public interface ISaveBankAccountCommand
    {
        Task Execute(SaveBankAccountModel model);
    }
}
