using System;
using System.Reflection;

namespace OneBudget.Model.Common.Mapping
{
    public static class EntityMapper
    {
        public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination = null)
            where TSource : class
            where TDestination : class
        {
            TDestination target = destination ?? Activator.CreateInstance<TDestination>();

            foreach (PropertyInfo sourceProperty in typeof(TSource).GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                MapAsAttribute sourceMapAs = sourceProperty.GetCustomAttribute<MapAsAttribute>();
                string sourcePropertyName = sourceMapAs?.Name ?? sourceProperty.Name;

                PropertyInfo targetProperty = typeof(TDestination).GetProperty(sourcePropertyName);

                if (targetProperty.PropertyType.Equals(sourceProperty.PropertyType) && targetProperty.CanWrite)
                {
                    targetProperty.SetValue(target, sourceProperty.GetValue(source));
                }
            }

            return target;
        }
    }
}
