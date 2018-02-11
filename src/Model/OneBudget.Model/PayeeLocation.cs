using System;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class PayeeLocation : IEntity
    {
        public Guid Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
