using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace entityframeworkconsole
{
    class mydbcontext : DbContext
    {

        public mydbcontext():base("eydb")
        {
            Database.SetInitializer<mydbcontext>(new CreateDatabaseIfNotExists<mydbcontext>());
        }
       
        public DbSet<Employee> Employees { get; set; }
    }
}
