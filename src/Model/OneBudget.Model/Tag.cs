using System;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Tag : IEntity
    {
        public Guid Id { get; set; }

        public string Color { get; set; }
        public string Name { get; set; }
    }
}
