using System;

namespace OneBudget.Model.Common.Mapping
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MapAsAttribute : Attribute
    {
        public MapAsAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
