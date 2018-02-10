using System;
using System.Collections.Generic;
using System.Text;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Budget : IEntity
    {
        public Guid Id { get; set; }

        public IEnumerable<Category> Categories { get; }
        public IEnumerable<Tag> Tags { get; }
    }
}
