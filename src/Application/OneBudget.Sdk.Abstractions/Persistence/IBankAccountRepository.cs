using System;
using System.Collections.Generic;
using System.Text;

using OneBudget.Model;
using OneBudget.Sdk.Persistence.Common;

namespace OneBudget.Sdk.Persistence
{
    public interface IBankAccountRepository : IRepository<BankAccount> { }
}
