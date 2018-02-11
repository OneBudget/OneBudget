using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using OneBudget.Model.Common;

namespace OneBudget.Sdk.Persistence.Common
{
    public interface IRepository<T>
        where T : IEntity
    {
        Task Delete(Guid id);
        Task<T> Get(Guid id);
        Task<IEnumerable<T>> Query(Expression<Func<T, bool>> predicate = null);
        Task Save(T entity);
    }
}
