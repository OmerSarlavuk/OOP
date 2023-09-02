using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            /*
            var result = from sayi in sayilar
                         where sayi >= 5
                         select sayi;
            */

            var result = sayilar.Where(x => x >= 5).ToList();

            Console.WriteLine("5 ten buyuk sayilar");

            foreach (var sayi in result)
            {
                Console.Write(sayi + " ");
            }
            Console.ReadLine();
        }
    }
}
