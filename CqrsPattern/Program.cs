using System;
namespace CqrsPattern
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class SaveDataCommand
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
