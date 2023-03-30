using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using linqtosqlmvcnew.Models;

namespace linqtosqlmvcnew.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        employeeDataContext X = new employeeDataContext
          ("Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=ey;Integrated Security=True");
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {

            var data = from s in X.employees
                       select s;
            ViewBag.edata = data;
           
            return View();
        }
        public ActionResult Insert()
        {
          //  int id=get
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }

       
        public ActionResult Delete()
        {
            return View();
        }
    }
}