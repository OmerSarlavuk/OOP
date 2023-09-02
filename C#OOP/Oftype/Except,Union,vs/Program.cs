using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Except_Union_Concat_Intersect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isim1 = new List<string> {"Omer", "Azra", "Zara", "Naz" };

            List<string> isim2 = new List<string> { "Omer", "Naz", "Asya", "Aban"};

            var fark = isim1.Except(isim2);//ilk verilen dizi ile yani isim1, ikinci verilen dizi (isim2) farkını bulur...

            var birlesim1 = isim1.Union(isim2);//buda birleşimlerini alıyor aynı olanları sadece bir kere alıyor iki kere değil...

            var birlesim2 = isim1.Concat(isim2);//concat ise aynı felan görmez ne var yok ne yok ise birleşim halinde yazar...

            var kesisim = isim1.Intersect(isim2);//kesişim alır, yani aynı olanlar...

            foreach(var f in kesisim)
            {
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}
