using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityframeworkconsole
{
    class Employee
    { 

        public Employee()
        {

        }
        [Key]
        public int eid { get; set; }
        public string ename { get; set; }
        public float esal { get; set; }
        public string erole { get; set; }
    }
}
