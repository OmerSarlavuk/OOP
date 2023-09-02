using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inheritance yapılırken bir sınıf sadece bir sınıfa kalıtım verebilir ancak interfacelerde
            //bir sınıf birden çok interfaci implement edebiliyordu...
            //inheritance de arabirim uygulamak yoktur kalıtım alan sınıfın kendine ait field ve methodları olabilir.
            //inheritance olan sınıf yani kalıtım veren sınıfta newlenebilir ama interface de interface olan sınıf newlenemezdi...
            Person[] person = new Person[3]
            {
                new Person
                {
                    FirstName = "Omer"
                },
                new Robot
                {
                    FirstName = "Zara"
                },
                new Customer
                {
                    FirstName = "Azra"
                }
            };

            foreach (var p in person)
            {
                Console.WriteLine("FirstName: {0} ", p.FirstName);
            }

            Console.ReadLine();

        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string City { get; set; }
        }

        class Robot : Person
        {
            public string Color { get; set; }
        }

    }
}
