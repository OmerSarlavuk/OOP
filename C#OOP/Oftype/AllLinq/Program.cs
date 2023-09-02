using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> Student = new List<Students>();
           
            Student.Add(new Students
            {
                Id = 1,
                Name = "Omer",
                TrueorFalse = true
            });
            
            Student.Add(new Students
            {
                Id=2,
                Name = "Asya",
                TrueorFalse = true
            });

            Student.Add(new Students
            {
                Id=3,
                Name = "Naz",
                TrueorFalse = false
            });

            Student.Add(new Students
            {
                Id = 4,
                Name = "Zara",
                TrueorFalse=true
            });

            Student.Add(new Students
            {
                Id = 5,
                Name = "Aban",
                TrueorFalse = false
            });

            bool StudentOk = Student.All(student => student.TrueorFalse == true);


            //All methodu içerideki koşula göre tüm elemanlara bakar ve eğer bir tane bile uymuyorsa 
            //direk false döndürür.

            bool StudentAny = Student.Any(student => student.TrueorFalse != true);

            //Any methoduda koşulu sağlayan şeye göre hiç bir tane bile var mı varsa eğer bir tane dahi olsa direk true döndürür.

            Console.WriteLine(StudentAny);
            Console.WriteLine(StudentOk);

            Console.ReadLine();
        }
    }

    class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool TrueorFalse { get; set; }
    }

}
