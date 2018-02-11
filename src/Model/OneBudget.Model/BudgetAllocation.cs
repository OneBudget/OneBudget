using System;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class BudgetAllocation : IEntity
    {
        public Guid Id { get; set; }

        public decimal Amount { get; set; }
        public Budget Budget { get; set; }
        public Category Category { get; set; }
        public short Month { get; set; }
        public short Year { get; set; }
    }
}
