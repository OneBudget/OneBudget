using System;
using System.Collections.Generic;

namespace OneBudget.Sdk.Queries
{
    public class GetBudgetModel
    {
        public Guid Id { get; set; }
        public IEnumerable<GetBudgetBankAccountModel> BankAccounts { get; set; }
        public IEnumerable<GetBudgetCategoryModel> Categories { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateLastAccessed { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public IEnumerable<GetBudgetPayeeModel> Payees { get; set; }
        public IEnumerable<GetBudgetTagModel> Tags { get; set; }
    }
}
