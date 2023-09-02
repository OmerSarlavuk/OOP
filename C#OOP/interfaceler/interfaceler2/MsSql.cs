using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceler2
{
    public class MsSql : CRUD
    {
        public void Add()
        {
            Console.WriteLine("MsSql Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("MsSql Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MsSql Server Updated");
        }
    }
}
