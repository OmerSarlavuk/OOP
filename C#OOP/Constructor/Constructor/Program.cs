using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             MyClass2 myClass2 = new MyClass2();

             myClass2.Id = 5;
             myClass2.Method();
             Console.WriteLine("isim: {0}, id: {1}" ,  myClass2.Name, myClass2.Id);
            */

            /*
            Teacher.Name = 10;

            Console.WriteLine("sayi: {0}", Teacher.Name);
            */
            Console.ReadLine();
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Product(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
        }
    }   
    //Product içinde property ile constructor kullanıp hazır olarak değer atma işlemi kullanımı.


    //eğer değerleri set etmek istiyorsak;

    class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private int _Id;
        private string _Name;

        public Products()
        {
            _Id = Id;
            Name = Name;
        }

        public void List(int _Id, string _Name)
        {
            Console.WriteLine(_Id + _Name);
        }
    }
    //bu şekilde bir kullanım yapabiliriz tanımladığımız fieldlar üzerinden değişiklik yapabiliriz.

    class MyClass
    {
        public int Id = 1;
  
        public void Method()
        {
            Console.WriteLine("Method is plays");
        }
    }

    class MyClass2 : MyClass 
    {
        public string Name = "Omer";
    }

    static class Teacher
    {
        public static int Name { get; set; }
    }
    //static classlar newlenemez bellekte tutulur ve program boyunca rahatça newlenmeden erişilebilirler.
    //static bir fielda veya methoda newlemeden her yerden erişebilirsin rahatça...

}
