using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webservices
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int addition(int a,int b)
        {
            return (a+b);
        }

        [WebMethod]
        public int subtraction(int a, int b)
        {
            return (a - b);
        }

        [WebMethod]
        public int multiplication(int a, int b)
        {
            return (a * b);
        }

        [WebMethod]
        public int division(int a, int b)
        {
            return (a / b);
        }
    }
}
