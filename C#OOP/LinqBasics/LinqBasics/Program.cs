using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person
            {
                Id = 1,
                Name = "Omer"
            });

            persons.Add(new Person
            { 
                Id = 2,
                Name = "Asya"
            });
           
            persons.Add(new Person
            { 
                Id = 3,
                Name = "Naz"
            });

            //var result = from person in persons
            //             where person.Name.Contains("A")
            //             select person.Name;

            //sql de -> select * from tablo ismi where (koşul) diyorduk hemen hemen aynısı...

            //bu sorguyu => lambda operatörü kullanarakta yapabiliyoruz...
            
            var result = persons.Where(x => x.Name.Contains("A"))
                .Select(c => c.Name).ToList();


            Console.WriteLine(result.First());

            Console.ReadLine();
        }
    }
   
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
