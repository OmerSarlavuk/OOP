using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();

            var result = utilities.BuildList<string>("Ankara", "Çorum", "İzmir");

            foreach(var results in result) 
            {
                Console.WriteLine(results);
            }

            var resultss = utilities.BuildList<Customer>(new Customer
            {
                Name = "Name1"
            }, 
            new Customer
            {
                Name = "Name2"
            });

            foreach(var k in resultss)
            {
                Console.WriteLine(k.Name);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] key)
        {
            return new List<T>(key);
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}
