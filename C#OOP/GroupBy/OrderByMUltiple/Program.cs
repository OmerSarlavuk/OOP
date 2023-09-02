using OrderByMUltiple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{ Id = 1, Name = "Omer", Gender = "Female", Branch = "MIT", Age = 21},
                new Student{ Id = 2, Name = "Eren", Gender = "Female", Branch = "MIT", Age = 25},
                new Student{ Id = 3, Name = "Naz",  Gender = "Male",   Branch = "IT",  Age = 19},
                new Student{ Id = 4, Name = "Asya", Gender = "Male",   Branch = "MIT", Age = 20},
                new Student{ Id = 5, Name = "Zara", Gender = "Male",   Branch = "MIT", Age = 12},
                new Student{ Id = 6, Name = "Ugur", Gender = "Female", Branch = "IT",  Age = 29},
                new Student{ Id = 7, Name = "Kara", Gender = "Female", Branch = "MIT", Age = 26},
                new Student{ Id = 8, Name = "Mavi", Gender = "Male",   Branch = "IT",  Age = 23}
            };
            

        }
    }
    
    class Student : Students
    {

    }

}
