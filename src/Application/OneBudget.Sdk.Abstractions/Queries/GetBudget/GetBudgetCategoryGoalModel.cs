using System;

namespace OneBudget.Sdk.Queries
{
    public class GetBudgetCategoryGoalModel
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Color { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
    }
}
