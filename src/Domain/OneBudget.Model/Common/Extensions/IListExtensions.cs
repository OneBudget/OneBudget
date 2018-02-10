using System;
using System.Collections.Generic;
using System.Linq;

using OneBudget.Model.Common.Mapping;

namespace OneBudget.Model.Common
{
    public static partial class IListExtensions
    {
        /// <summary>
        /// Gets an entity by its ID.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="id">The ID of the entity to retrieve.</param>
        /// <returns></returns>
        public static T GetById<T>(this IList<T> list, Guid id)
            where T : IEntity
        {
            return list.FirstOrDefault(x => x.Id.Equals(id));
        }

        /// <summary>
        /// Removes an entity based on the entity's ID.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="id">The ID of the entity to remove.</param>
        public static void RemoveById<T>(this IList<T> list, Guid id)
            where T : IEntity
        {
            T entity = list.FirstOrDefault(x => x.Id.Equals(id));

            if (entity != null)
            {
                list.Remove(entity);
            }
        }

        /// <summary>
        /// Adds or updates an entity based on the entity's ID.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="entity">The entity to add or update.</param>
        public static void Upsert<T>(this IList<T> list, T entity)
            where T : class, IEntity
        {
            T existingEntity = list.FirstOrDefault(x => x.Id.Equals(entity.Id));

            if (existingEntity == null)
            {
                list.Add(entity);
            }

            else
            {
                EntityMapper.Map(entity, existingEntity);
            }
        }
    }
}
