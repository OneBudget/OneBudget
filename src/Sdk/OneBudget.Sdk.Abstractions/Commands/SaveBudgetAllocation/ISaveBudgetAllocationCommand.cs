using System.Threading.Tasks;

namespace OneBudget.Sdk.Commands
{
    public interface ISaveBudgetAllocationCommand
    {
        Task Execute(SaveBudgetAllocationModel model);
    }
}
