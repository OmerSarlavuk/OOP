using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> student = new List<Students>();

            student.Add(new Students
            {
                Id = 1,
                Name = "Zara",
                Rank = 10
            });
            student.Add(new Students
            {
                Id=2,
                Name = "Azra",
                Rank = 6
            });

            student.Add(new Students
            {
                Id=3,
                Name = "Omer",
                Rank = 18
            });


            //querry syntax ile yazımı...
            /*
            var result = from students in student
                         orderby students.Rank
                         select students;
            */

            //method syntax ile yazım şekli...
            //var result = student.OrderBy(x => x.Rank).ToList();

            var result = student.OrderByDescending(x => x.Rank).ToList();//tersten sıralama yapar...

            foreach (var x in result)
            {
                Console.WriteLine("Name: {0}", x.Name);
            }

            Console.ReadLine();
        }
    }

    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
    }



}
