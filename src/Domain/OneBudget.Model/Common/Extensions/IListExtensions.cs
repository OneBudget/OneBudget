using System;
using System.Collections.Generic;
using System.Linq;

namespace OneBudget.Model.Common
{
    public static partial class IListExtensions
    {
        /// <summary>
        /// Removes an entity from an IList using the entity's ID.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="id">The ID of the entity to remove.</param>
        /// <returns>True if an entity was found and removed, false otherwise.</returns>
        public static bool RemoveById<T>(this IList<T> list, Guid id)
            where T : IEntity
        {
            bool removed = false;
            T entity = list.FirstOrDefault(x => x.Id.Equals(id));

            if (entity != null)
            {
                list.Remove(entity);
                removed = true;
            }

            return removed;
        }
    }
}
