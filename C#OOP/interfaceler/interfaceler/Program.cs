 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Method method = new Method();

            method.Info("Omer");
            
            Console.ReadLine(); 
        }
    }

    public interface ILogger
    {
        void Info(string message);

        int Id { get; set; }
        string Name{ get; set; }
    }

    public class Method : ILogger
    {
       public void Info(string message)
       {
            Console.WriteLine("string ifade: {0}", message);
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }



}
