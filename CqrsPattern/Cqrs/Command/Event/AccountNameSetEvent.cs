using SimpleCqrs.Eventing;

namespace CqrsPattern.Cqrs.Command
{
    public class AccountNameSetEvent : DomainEvent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
