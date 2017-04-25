using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
