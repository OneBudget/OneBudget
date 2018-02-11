using System;
using System.Threading.Tasks;

using AutoMapper;

using OneBudget.Model;
using OneBudget.Sdk.Persistence;

namespace OneBudget.Sdk.Queries
{
    public class GetBudgetQuery : IGetBudgetQuery
    {
        private readonly IBudgetRepository _budgetRepository;
        private readonly IMapper _mapper;

        public GetBudgetQuery(IBudgetRepository budgetRepository, IMapper mapper)
        {
            _budgetRepository = budgetRepository;
            _mapper = mapper;
        }

        public async Task<GetBudgetModel> Execute(Guid id)
        {
            Budget budget = await _budgetRepository.Get(id);
            GetBudgetModel model = _mapper.Map<GetBudgetModel>(budget);

            return model;
        }
    }
}
