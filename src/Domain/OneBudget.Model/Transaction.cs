using System;
using System.Collections.Generic;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Transaction : IEntity
    {
        public Transaction()
        {
            Tags = new List<Tag>();
        }

        public Guid Id { get; set; }

        public decimal Amount { get; set; }
        public BankAccount Account { get; set; }
        public Budget Budget { get; set; }
        public Category Category { get; set; }
        public DateTimeOffset DateCleared { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateCreatedFor { get; set; }
        public string Notes { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
