using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcapi.Models
{
    public class SqlDbContext:DbContext
    {
           public SqlDbContext():base("name=sqlcon")
        {

        }
        public DbSet<employee> employees { get; set; }
    }
}
