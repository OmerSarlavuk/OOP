using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //virtual-override ikilisi şu şekşlde açıklayabilirim...
            //bir sınıfta bir method tanımladık ve bir sınıfa inheritance verdik inheritance alan sınıf eğer
            //bu methodu yeniden dizayn etmek isterse biz bu keywordleri kullanmak zorundayız örneğin;
            //eğer bir sınıfı abstract olarak tanımlıyorsan ve içeriğinde bir methodu abstract olarak tanımlıyorsan
            //bu sınıf başka sınıflara kalıtım olarak verdiğin zaman abstract olarak tanımladığın bu methodu 
            //kalıtım alan sınıfta ezmek, değiştirmek zorundasın.  (abstract-override)



            Person person = new Person();
            Customer customer = new Customer();

            person.Add();
            customer.Add();
            
            Console.ReadLine();

        }

        class Person
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by Default");
            }
        }

        class Customer : Person
        {
            //burada ezme işlemi yaptık...
            public override void Add()
            {
                Console.WriteLine("DEfault"); 
            }
        }

    }
}
