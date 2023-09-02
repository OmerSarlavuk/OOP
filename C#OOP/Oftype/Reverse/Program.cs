using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int> { 20, 100, 15, 4, 6, 23, 54, 900};

            foreach(var sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }

            sayilar.Reverse();//reverse etme eylemi altını üstüne getirme denebilir tam olarak...
            Console.WriteLine();

            foreach (var sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }

            Console.ReadLine();
        }
    }
}
