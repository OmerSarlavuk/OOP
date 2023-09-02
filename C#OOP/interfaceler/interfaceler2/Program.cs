using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceler2
{
    public class Program
    {
        static void Main(string[] args)
        {



            /*
          MsSql msSql = new MsSql();
          msSql.Add();

          Oracle oracle = new Oracle();
          oracle.Add();

          SQLServer sQLServer = new SQLServer();
          sQLServer.Add();
          */



            /*
            MsSql msSql = new MsSql();
            Oracle oracle = new Oracle();
            SQLServer sQLServer = new SQLServer();

            CRUD[] cRUDs = new CRUD[3]
            {
                 msSql, oracle,sQLServer
            };

            foreach(var crud in cRUDs)
            {
                crud.Add();
            }
            */




            /*
            //burada da customermanager dan direk olarak bu methodu çağırıp newleyerek ulaşma sağladık. 
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new SQLServer());
            */

        }
    }
}
