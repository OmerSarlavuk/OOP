using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMany
{
    class Employee
    {
        public int ID { get; set; }

        public List<Department> Departmens { get; set; }

    }
    class Department
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee
            {
                ID = 1,
                Departmens = new List<Department> 
                {
                    new Department 
                    {
                        Name = "Products"
                    }
                }
            });
            employees.Add(new Employee
            {
                ID = 2,
                Departmens = new List<Department>
                {
                    new Department
                    {
                        Name = "Customers"
                    }
                }
            });
            employees.Add(new Employee
            {
                ID = 3,
                Departmens = new List<Department>
                {
                    new Department
                    {
                        Name = "Marketing"
                    }
                }
            });
            employees.Add(new Employee
            {
                ID = 4,
                Departmens = new List<Department>
                {
                    new Department
                    {
                        Name = "CEO"
                    }
                }
            });
            employees.Add(new Employee
            {
                ID = 5,
                Departmens = new List<Department>
                {
                    new Department
                    {
                        Name = "Managemenet Asistant"
                    }
                }
            });
            employees.Add(new Employee
            {
                ID = 6,
                Departmens = new List<Department>
                {
                    new Department
                    {
                        Name = "Gard"
                    }
                }
            });
            employees.Add(new Employee
            {
                ID = 7,
                Departmens = new List<Department>
                {
                    new Department
                    {
                        Name = "Administ"
                    }
                }
            });
            //selectmany birçok seçim yapar örneğin aşağıda employe.Departmens olanları
            //seçer ve koleksiyon halinde döner...

            var result = employees.SelectMany(employe => employe.Departmens).ToList();

            foreach(var department in result)
            {
                Console.WriteLine(department.Name);
            }

            Console.ReadLine();
        }
    }
}
