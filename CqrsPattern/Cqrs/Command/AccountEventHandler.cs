using System.Linq;
using SimpleCqrs.Eventing;
using CqrsPattern.Cqrs.Db;

namespace CqrsPattern.Cqrs.Command
{
    public class AccountEventHandler : IHandleDomainEvents<AccountCreatedEvent>,
                                             IHandleDomainEvents<AccountNameSetEvent>
    {
        private readonly FakeAccountTable accountTable;

        public AccountEventHandler(FakeAccountTable accountTable)
        {
            this.accountTable = accountTable;
        }

        public void Handle(AccountCreatedEvent domainEvent)
        {
            accountTable.Add(new FakeAccountTableRow { Id = domainEvent.AggregateRootId });
        }

        public void Handle(AccountNameSetEvent domainEvent)
        {
            var account = accountTable.Single(x => x.Id == domainEvent.AggregateRootId);
            account.Name = domainEvent.FirstName + " " + domainEvent.LastName;
        }
    }
}