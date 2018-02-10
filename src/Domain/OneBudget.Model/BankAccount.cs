using System;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class BankAccount : IEntity
    {
        public Guid Id { get; set; }

        public DateTimeOffset DateOpened { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public decimal OpeningBalance { get; set; }
        public BankAccountType Type { get; set; }
    }
}
