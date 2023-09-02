using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceler2
{
    public class Oracle : CRUD
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server Updated");
        }
    }
}
