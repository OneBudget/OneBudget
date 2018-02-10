using System;
using System.Collections.Generic;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Category : IEntity
    {
        private readonly IList<Goal> _goals;
        private readonly IList<Category> _subCategories;

        public Category()
        {
            _goals = new List<Goal>();
            _subCategories = new List<Category>();
        }

        public Guid Id { get; set; }

        public string Color { get; set; }
        public IEnumerable<Goal> Goals { get { return _goals; } }
        public string Name { get; set; }
        public IEnumerable<Category> SubCategories { get { return _subCategories; } }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void AddSubCategory(Category category)
        {
            _subCategories.Add(category);
        }

        public void RemoveGoal(Guid id)
        {
            _goals.RemoveById(id);
        }

        public void RemoveSubCategory(Guid id)
        {
            _subCategories.RemoveById(id);
        }
    }
}
