using System;

namespace OneBudget.Sdk.Queries
{
    public class GetBudgetBankAccountModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateOpened { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public decimal OpeningBalance { get; set; }
        public string Type { get; set; }
    }
}
