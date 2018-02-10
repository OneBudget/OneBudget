using System;

using OneBudget.Model;
using OneBudget.Model.Common.Mapping;

namespace OneBudget.Sdk.Commands
{
    public class SaveBankAccountModel
    {
        [MapAs("Id")]
        public Guid BankAccountId { get; set; }

        public Guid BudgetId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public decimal OpeningBalance { get; set; }
        public BankAccountType Type { get; set; }
    }
}
