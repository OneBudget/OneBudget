using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneBudget.Sdk.Queries
{
    public interface IListBudgetsQuery
    {
        Task<IEnumerable<ListBudgetsModel>> Execute(Guid tenantId);
    }
}
