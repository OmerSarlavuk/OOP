using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oftype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> course = new List<Course>();
            
            course.Add(new FreeCourse
            {
                CourseId = 1,
                CourseName = "C#",
                CourseDescription = ".NetCore Projects"
            });

            course.Add(new FreeCourse
            {
                CourseId= 2,
                CourseName = "C Programming",
                CourseDescription = "Linux Software "
            });

            course.Add(new ManyCourse
            {
                CourseId = 4,
                CourseName = "LİNQ",
                CourseDescription = "EntityFrameWorkCodeFirst",
                CourseMany = 100
            });
            course.Add(new ManyCourse
            {
                CourseId = 5,
                CourseName = "MVC restfulAPI",
                CourseDescription = ":NET Core MVC with API projects",
                CourseMany = 200
            });

            //linq sorgusu ataması işlemi, ilk önce method syntax ile ...

            //var result = course.OfType<ManyCourse>().ToList();

            var result = from courses in course.OfType<FreeCourse>()
                         select courses;
                         

            foreach(var results in result)
            {
                Console.WriteLine("Description: {0}", results.CourseDescription);
            }

            Console.ReadLine();

        }
    }

    abstract class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
    }

    internal class FreeCourse : Course 
    {

    }
    
    internal class ManyCourse : Course
    {
        public int CourseMany { get; set; }
    }

}
