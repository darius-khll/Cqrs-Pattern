using System;
using SimpleCqrs.Commanding;
using SimpleCqrs.Domain;

namespace CqrsPattern.Cqrs.Command
{
    public class CreateAccountCommandHandler : CommandHandler<CreateAccountCommand>
    {
        private readonly IDomainRepository repository;

        public CreateAccountCommandHandler(IDomainRepository repository)
        {
            this.repository = repository;
        }

        public override void Handle(CreateAccountCommand command)
        {
            var account = new Account(Guid.NewGuid());
            //account.SetName(command.FirstName, command.LastName);

            repository.Save(account);
        }
    }
}