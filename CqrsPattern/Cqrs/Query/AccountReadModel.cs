using System;

namespace CqrsPattern.Cqrs.Query
{
    public class AccountReadModel
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}
