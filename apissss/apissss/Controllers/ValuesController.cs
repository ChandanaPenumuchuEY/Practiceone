using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apissss.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "1", "2","3","4","5" };
        //}
        eyEntities db = new eyEntities();
        public IEnumerable<employee> Get()
        {
            return db.employees.ToList();
        }

        // GET api/values/5
        public employee Get(int id)
        {
            employee e = db.employees.Find(id);
            return e ;
        }
       

        // POST api/values
        public void Post(employee value)
        {
            //employee e = value;
            db.employees.Add(value);
            db.SaveChanges();


        }

        // PUT api/values/5
        public void Put(int id, employee value)
        {
            employee x = db.employees.Find(id);
            x.ename = value.ename;
            db.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            employee x = db.employees.Find(id);
            db.employees.Remove(x);
            db.SaveChanges();
        }
    }
}
