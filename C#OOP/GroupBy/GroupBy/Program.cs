using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> Student = new List<Students>()
            {
                new Students{ Id = 1, Name = "Omer", Gender = "Female", Branch = "MIT", Age = 21},
                new Students{ Id = 2, Name = "Eren", Gender = "Female", Branch = "MIT", Age = 25},
                new Students{ Id = 3, Name = "Naz",  Gender = "Male",   Branch = "IT",  Age = 19},
                new Students{ Id = 4, Name = "Asya", Gender = "Male",   Branch = "MIT", Age = 20},
                new Students{ Id = 5, Name = "Zara", Gender = "Male",   Branch = "MIT", Age = 12},
                new Students{ Id = 6, Name = "Ugur", Gender = "Female", Branch = "IT",  Age = 29},
                new Students{ Id = 7, Name = "Kara", Gender = "Female", Branch = "MIT", Age = 26},
                new Students{ Id = 8, Name = "Mavi", Gender = "Male",   Branch = "IT",  Age = 23}
            };

            var result2 = from stu in Student group stu by stu.Branch;//bu da querry syntax


            var result = Student.GroupBy(student => student.Branch).ToList();

            //.Key ilgili ayrımın içeriğini döndürür örneğin burada Branch değerini döndürüyür
            //çünkü biz Brancha göre groupby yaptık...

            foreach(var student in result)
            {
                //(bu işem branchları ve sayısını ifade eder)
                Console.WriteLine(student.Key + " : " + student.Count());
                foreach(var student2 in student)
                {
                    Console.WriteLine(student2.Name);
                }
            }
            Console.ReadLine();
        }
    }
    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Branch { get; set; }
        public int Age { get; set; }
    }
}
