using System;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Goal : IEntity
    {
        public Guid Id { get; set; }

        public decimal Amount { get; set; }
        public string Color { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public GoalType Type { get; set; }
    }
}
