using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace axpwebapp.Controllers
{
    public class StudentController : ApiController
    {
        // GET: Student
        public IEnumerable<string> Get()
        {
            string[] students = { "chandu", "mintu", "honey", "ishi", "pooji", "ramboo", "pranathi" };
            return students;
        }
        public ActionResult Index()
        {
         return View();
        }
    }
}