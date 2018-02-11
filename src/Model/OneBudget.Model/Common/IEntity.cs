using System;

namespace OneBudget.Model.Common
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
