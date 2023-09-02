using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggreGate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>() 
            { 10,  20 , 30, 40, 50, 60};

            
            //excelde de var olan sum, min, max, avarage hazır fonksiyonları...
            //iki türlü gösterim hem method hem de querry syntax şeklinde...

            int sum = sayilar.Sum();             //toplamlarını bulur
            int sum2 = (from s in sayilar select s).Sum();

            int max = sayilar.Max();             //max elemanı bulur
            int max2 = (from m in sayilar select m).Max();    
                                                
            int min = sayilar.Min();             //min elemanı bulur
            int min2 = (from mi in sayilar select mi).Min();

            int avr = (int)sayilar.Average();    //ortalama alır, double alıyor...
            int avr2 = (int)(from av in sayilar select av).Average();

            int count = sayilar.Count();         //kaç eleman olduğunu bulur
            int count2 = (from co in sayilar select co).Count();


            //bu aggregate operasyonu iki stringi nasıl yazdırmak istediğinle ilgilenir.
            //çok ama çok büyük yardımcı oluyor bu hazır fonksiyon...
            //burada kullandığımız x ve y tamamen hayali herşey kullanılabilir...

            //string[] skills = { "MVC", "Dotnet", "EFCore", "SQL" };

            List<string> skills = new List<string>()
            {
                "MVC", "Dotnet", "EFCore", "SQL"
            };

            var result = skills.Aggregate((x, y) => x + ", " + y);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
