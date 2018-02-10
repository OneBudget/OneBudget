using System.Threading.Tasks;

using OneBudget.Model;

namespace OneBudget.Sdk.Factories
{
    public interface IBankAccountFactory
    {
        Task<BankAccount> Create();
    }
}
