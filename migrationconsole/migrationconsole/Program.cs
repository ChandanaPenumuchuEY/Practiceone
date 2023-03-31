using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using migrationconsole.Models;

namespace migrationconsole
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new employeecontext())
            {
                context.Employees.Add(new Employee { eid = 500, ename = "mintu" });
                context.Employees.Add(new Employee { eid = 501, ename = "chandu" });
                context.Employees.Add(new Employee { eid = 502, ename = "honey" });

                context.SaveChanges();

                foreach (var emp in context.Employees)
                {
                    Console.WriteLine(emp.eid + " " + emp.ename);
                }
            }
            Console.ReadKey();
        }
    }
}
