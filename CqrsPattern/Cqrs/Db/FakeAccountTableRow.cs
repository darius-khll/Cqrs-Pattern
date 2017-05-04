using System;

namespace CqrsPattern.Cqrs.Db
{
    public class FakeAccountTableRow
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}