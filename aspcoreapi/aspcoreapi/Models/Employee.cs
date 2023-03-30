using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspcoreapi.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int eid { get; set; }
        public string ename { get; set; }
        public float esal { get; set; }
        public string erole { get; set; }


    }
}
