using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using studentmvc.Models;

namespace studentmvc.Controllers
{
    public class StudentController : Controller
    {
           List<student> sdata = new List<student>()
            {
               new student(){sid=1,sname="chandu"},
               new student(){sid=2,sname="mintu"},
               new student(){sid=3,sname="honey"},
               new student(){sid=4,sname="teja"},
               new student(){sid=5,sname="shashi"},
               new student(){sid=6,sname="varun"}
            };
        public IActionResult Index()
        {
            ViewBag.scount = sdata.Count;
            ViewBag.sdetails = sdata;
            return View();
        }
    }
}
