using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aspcoreapi.Models
{
    public class dbcontext:DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Emprole> Emproles { get; set; }

    }
}
