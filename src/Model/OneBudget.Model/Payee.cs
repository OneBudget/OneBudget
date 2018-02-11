using System;
using System.Collections.Generic;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class Payee : IEntity
    {
        public Payee()
        {
            Locations = new List<PayeeLocation>();
        }

        public Guid Id { get; set; }

        public List<PayeeLocation> Locations { get; set; }
        public string Name { get; set; }
    }
}
