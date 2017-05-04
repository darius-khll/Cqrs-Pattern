using CqrsPattern.Cqrs.Db;
using System.Collections.Generic;
using System.Linq;

namespace CqrsPattern.Cqrs.Query
{
    public class AccountReportReadService
    {
        private FakeAccountTable fakeAccountDb;

        public AccountReportReadService(FakeAccountTable fakeAccountDb)
        {
            this.fakeAccountDb = fakeAccountDb;
        }

        public IEnumerable<AccountReadModel> GetAccounts()
        {
            return from a in fakeAccountDb
                   select new AccountReadModel { Id = a.Id, Name = a.Name };
        }
    }
}