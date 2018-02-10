using System;
using System.Collections.Generic;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Budget : IEntity
    {
        public Budget()
        {
            BankAccounts = new List<BankAccount>();
            Categories = new List<Category>();
            Payees = new List<Payee>();
            Tags = new List<Tag>();
        }

        public Guid Id { get; set; }

        public List<BankAccount> BankAccounts { get; set; }
        public List<Category> Categories { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateLastAccessed { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public List<Payee> Payees { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
