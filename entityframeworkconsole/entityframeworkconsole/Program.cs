using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityframeworkconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            mydbcontext d = new mydbcontext();
            Employee e = new Employee { eid = 1, ename = "chandu", esal = 45454, erole = "software" };
            d.Employees.Add(e);
            d.SaveChanges();
        }
    }
}
