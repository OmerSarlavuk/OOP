using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWhere
{
    class Course
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public int Rank { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> Courses = new List<Course>();

            Courses.Add(new Course
            {
                Id = 1,
                Subject = "Asp.NetCore MVC",
                Rank = 2
            });

            Courses.Add(new Course
            {
                Id = 2,
                Subject = "MicrosoftEntityFrameworkCore",
                Rank = 3
            });

            Courses.Add(new Course
            {
                Id= 3,
                Subject = "RestfulAPI",
                Rank = 4
            });

            /*
             * querry syntax yazımı şekli budur.
             from x in Courses
                where x.Rank >= 4
                   select x
             */


            //Contains içinde var mı yok mu ona bakar string parametre alır.
            //bunun karşılığı yukarı da açıkladım...
            //buda method syntax yazım şeklidir daha pratiktir.


            var result = Courses.Where(Course => Course.Rank <= 4 && 
            Course.Subject.Contains("Microsoft") || Course.Subject.Contains("Asp")).ToList();

            //koşul kullanımı ve çoklu koşul kullanımı bu şekildedir.where ile sıkıştır ve operatörleri kullan...


            foreach (var course in result)
            {
                Console.WriteLine("Subject: {0}", course.Subject);
            }

            Console.ReadLine();
        }
    }
}
