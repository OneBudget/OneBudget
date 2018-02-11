using System;

using OneBudget.Model.Common;

namespace OneBudget.Model
{
    public class User : IEntity
    {
        public Guid Id { get; set; }

        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
