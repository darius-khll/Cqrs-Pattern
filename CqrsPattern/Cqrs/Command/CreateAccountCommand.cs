using SimpleCqrs.Commanding;

namespace CqrsPattern.Cqrs.Command
{
    public class CreateAccountCommand : ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
