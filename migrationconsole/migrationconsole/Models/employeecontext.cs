using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace migrationconsole.Models
{
    public class employeecontext : DbContext
    {
        public employeecontext():base("migdb")
        {

        }
        public DbSet<Employee> Employees{ get; set; }
    }

    public class Employee
    {
        [Key]
        public int eid { get; set; }
        public string ename { get; set; }

        public string erole { get; set; }
        public int esal { get; set; }
    }
}
