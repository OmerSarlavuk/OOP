using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Product product = new Product();

            product.ProductName = "Test";
            product.ProductId = 1;

            Console.WriteLine("ProductName: {0}\nProductId: {1}" , product.ProductName, product.ProductId);

            Console.ReadLine();
        }
    }
}
