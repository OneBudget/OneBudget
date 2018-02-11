using System;
using System.Collections.Generic;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Tenant : IEntity
    {
        public Tenant()
        {
            Users = new List<User>();
        }

        public Guid Id { get; set; }

        public List<User> Users { get; set; }
    }
}
