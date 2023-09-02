using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipGuvenli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person{Id = 1, City = "Ankara", FirstName = "Omer", LastName = "Sarlavuk"},
                new Person{Id = 2, City = "Corum", FirstName = "Azra", LastName = "Sarlavuk"},
                new Person{Id = 3, City = "Istanbul", FirstName = "Naz", LastName = "Sarlavuk"}
            };


            /*
            eğer sonradan ekleme yapılacak ise şu şekilde yapılabilir.

            var person2 = new Person()
            {
                City = "İzmir",
                FirstName = "Zara",
                LastName = "Araz",
                Id = 10
            };

            persons.Add(person2);
            */

            /*
            Eğer yapılcak olan eklem yine birden çok kişi ise yani dizi şeklinde ise de
            
             persons.AddRange(new Person[2]
            {
                new Person { Id = 4, City = "Yozgat", FirstName = "Eren", LastName = "Nere"},
                new Person { Id = 5, City = "Sivas", FirstName = "Kara", LastName = "Arak"}

            });
            bu şekilde ekleme yapılıyor...
            */

            foreach (Person person in persons)
            {
                Console.WriteLine("FirstName: {0}", person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
