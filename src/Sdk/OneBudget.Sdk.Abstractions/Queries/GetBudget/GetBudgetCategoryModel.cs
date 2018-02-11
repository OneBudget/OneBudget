using System;
using System.Collections.Generic;

namespace OneBudget.Sdk.Queries
{
    public class GetBudgetCategoryModel
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
        public IEnumerable<GetBudgetCategoryGoalModel> Goals { get; set; }
        public string Name { get; set; }
        public IEnumerable<GetBudgetCategoryModel> SubCategories { get; set; }
    }
}
