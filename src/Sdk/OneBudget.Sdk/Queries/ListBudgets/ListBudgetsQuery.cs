using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AutoMapper;

using OneBudget.Model;
using OneBudget.Sdk.Persistence;

namespace OneBudget.Sdk.Queries
{
    public class ListBudgetsQuery : IListBudgetsQuery
    {
        private readonly IBudgetRepository _budgetRepository;
        private readonly IMapper _mapper;

        public ListBudgetsQuery(IBudgetRepository budgetRepository, IMapper mapper)
        {
            _budgetRepository = budgetRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ListBudgetsModel>> Execute(Guid tenantId)
        {
            IEnumerable<Budget> budgets = await _budgetRepository.Query(x => x.Tenant.Id.Equals(tenantId));
            IEnumerable<ListBudgetsModel> models = _mapper.Map<IEnumerable<ListBudgetsModel>>(budgets);

            return models;
        }
    }
}
