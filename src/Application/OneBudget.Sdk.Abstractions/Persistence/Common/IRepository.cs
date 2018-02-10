using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using OneBudget.Model.Common;

namespace OneBudget.Sdk.Persistence.Common
{
    public interface IRepository<T>
        where T : IEntity
    {
        Task Delete(Guid id);
        Task<T> Get(Guid id);
        Task<IEnumerable<T>> Query(Func<IQueryable<T>, IQueryable<T>> query);
        Task Save(T entity);
    }
}
