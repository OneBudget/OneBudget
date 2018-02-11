using System;

namespace OneBudget.Sdk.Commands
{
    public class SaveBudgetAllocationModel
    {
        public decimal Amount { get; set; }
        public Guid BudgetId { get; set; }
        public Guid CategoryId { get; set; }
        public short Month { get; set; }
        public short Year { get; set; }
    }
}
