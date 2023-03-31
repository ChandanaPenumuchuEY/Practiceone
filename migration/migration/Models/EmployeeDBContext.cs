using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace migration.Models
{
    public class EmployeeDBContext: DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options) { }
        
         public DbSet<Employee> Employees { get; set; }
    }
       
    
}
