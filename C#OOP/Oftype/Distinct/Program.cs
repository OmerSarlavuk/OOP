using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Distinct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>
            {
                "Omer", "Naz", "Asya", "Zara", "Araz", "Omer", "Naz", "Eren"
            };

            //(querry syntax)(from isim in isimler select isim).Distinct();

            var result = isimler.Distinct();//aynı olanları görmeden sıralar yani bir kere alır ...

            foreach(var isim in result)
            {
                Console.Write(isim + " ");
            }

            Console.ReadLine();
        }
    }
}
