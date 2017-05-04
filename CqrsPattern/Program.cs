using System;
using SimpleCqrs.Commanding;
using CqrsPattern.Cqrs.Query;
using CqrsPattern.Cqrs.Command;
using CqrsPattern.Cqrs.Db;

namespace CqrsPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var runtime = new SampleRunTime();

            runtime.Start();

            var fakeAccountTable = new FakeAccountTable();
            runtime.ServiceLocator.Register(fakeAccountTable);
            runtime.ServiceLocator.Register(new AccountReportReadService(fakeAccountTable));
            var commandBus = runtime.ServiceLocator.Resolve<ICommandBus>();

            var cmd = new CreateAccountCommand { FirstName = "Ali", LastName = "Kh" };

            commandBus.Send(cmd);

            var accountReportReadModel = runtime.ServiceLocator.Resolve<AccountReportReadService>();

            Console.WriteLine("Accounts in database");
            Console.WriteLine("####################");
            foreach (var account in accountReportReadModel.GetAccounts())
            {
                Console.WriteLine(" Id: {0} Name: {1}", account.Id, account.Name);
            }

            runtime.Shutdown();

            Console.ReadLine();
        }
    }
}
