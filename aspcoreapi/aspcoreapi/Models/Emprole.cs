using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspcoreapi.Models
{
    [Table("emprole")]
    public class Emprole
    {

        [Key]
        public int erid { get; set; }
        public string ername { get; set; }
    }
}
