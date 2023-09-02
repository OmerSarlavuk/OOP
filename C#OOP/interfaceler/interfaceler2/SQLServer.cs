using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceler2
{
    public class SQLServer : CRUD
    {
        public void Add()
        {
            Console.WriteLine("Sql Server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Server Updated");
        }
    }
}
