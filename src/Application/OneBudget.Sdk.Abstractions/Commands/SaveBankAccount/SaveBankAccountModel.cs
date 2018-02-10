using System;

using OneBudget.Model;

namespace OneBudget.Sdk.Commands
{
    public class SaveBankAccountModel
    {
        public Guid BankAccountId { get; set; }
        public Guid BudgetId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public decimal OpeningBalance { get; set; }
        public BankAccountType Type { get; set; }
    }
}
