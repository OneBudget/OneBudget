using System;
using System.Collections.Generic;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Category : IEntity
    {
        public Category()
        {
            Goals = new List<Goal>();
            SubCategories = new List<Category>();
        }

        public Guid Id { get; set; }

        public string Color { get; set; }
        public List<Goal> Goals { get; set; }
        public string Name { get; set; }
        public List<Category> SubCategories { get; set; }
    }
}
