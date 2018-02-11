using System;

namespace OneBudget.Sdk.Queries
{
    public class ListBudgetsModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset DateLastAccessed { get; set; }
        public string Name { get; set; }
    }
}
