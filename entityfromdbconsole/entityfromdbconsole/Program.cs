using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityfromdbconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var con=new eyEntities1())
            {
                var table = con.employees;
                foreach(var i in table)
                {
                    Console.WriteLine(i.eid + "  " + i.ename + "   " + i.erole);
                }
            }
            Console.ReadLine();
        }
    }
}
