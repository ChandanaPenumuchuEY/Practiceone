using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client x = new ServiceReference1.Service1Client();
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            Label1.Text = x.addition(a, b).ToString();
            Label2.Text = x.subtraction(a, b).ToString();
            Label3.Text = x.multiplication(a, b).ToString();
            Label4.Text = x.division(a, b).ToString();
        }
    }
}