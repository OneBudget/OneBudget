using System;

using OneBudget.Model.Common.Mapping;

namespace OneBudget.Sdk.Commands
{
    public class SaveBudgetAllocationModel
    {
        [MapAs("Id")]
        public Guid BudgetAllocationId { get; set; }

        public decimal Amount { get; set; }
        public Guid BudgetId { get; set; }
        public Guid CategoryId { get; set; }
        public short Month { get; set; }
        public short Year { get; set; }
    }
}
