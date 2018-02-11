using System;

namespace OneBudget.Sdk.Queries
{
    public class GetBudgetTagModel
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
    }
}
