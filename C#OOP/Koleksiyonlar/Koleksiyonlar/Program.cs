using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eğer belirli bir tip yoksa elimizde o halde arraylist kullanımı daha mantıklı ama belirli bir tip varsa
            //elimizde ve biz bunu biliyorsak tip güvenli koleksiyonları kullanmamız gereklidir.
            //List<> gibi...

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Omer");
            arrayList.Add("Corum");

            foreach(var array in arrayList) 
            {
                Console.WriteLine(array);
            }

            Console.ReadLine();
        }
    }
}
