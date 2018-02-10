using System;
using System.Collections.Generic;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Transaction : IEntity
    {
        private readonly IList<Tag> _tags;

        public Transaction()
        {
            _tags = new List<Tag>();
        }

        public Guid Id { get; set; }

        public decimal Amount { get; set; }
        public BankAccount Account { get; set; }
        public Budget Budget { get; set; }
        public Category Category { get; set; }
        public DateTimeOffset DateCleared { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public string Notes { get; set; }
        public IEnumerable<Tag> Tags { get { return _tags; } }

        public void AddTag(Tag tag)
        {
            _tags.Add(tag);
        }

        public void RemoveTag(Guid id)
        {
            _tags.RemoveById(id);
        }
    }
}
