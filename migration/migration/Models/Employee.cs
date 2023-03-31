using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace migration.Models
{
    public class Employee
    {
        [Key]
        public int eid { get; set; }
        public string ename { get; set; }
    }
}
