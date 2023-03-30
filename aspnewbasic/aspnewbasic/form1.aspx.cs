using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace aspnewbasic
{
    public partial class form1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog=ey;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            TextBox3.Text = Convert.ToString(a + b);
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            TextBox3.Text = Convert.ToString(a - b);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            TextBox3.Text = Convert.ToString(a * b);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            int b = int.Parse(TextBox2.Text);
            Response.Write("value is" + DropDownList1.SelectedItem.ToString());
            TextBox3.Text = Convert.ToString(a / b);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
         
           con.Open();
            Response.Write("Connected to databbase ey");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            DateTime cin = Calendar1.SelectedDate.Date;
            DateTime cout = Calendar2.SelectedDate.Date;
            Label1.Text = (cin - cout).ToString();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sa1 = new SqlDataAdapter("select * from employee",con);
            DataSet ds = new DataSet();
            sa1.Fill(ds);
          //  GridView2.DataSource = ds;
          //  GridView2.DataBind();

            CheckBoxList1.DataSource = ds;
            CheckBoxList1.DataTextField = "eid";
            CheckBoxList1.DataBind();
            

            RadioButtonList2.DataSource = ds;
            RadioButtonList2.DataTextField = "ename";
            RadioButtonList2.DataBind();

            BulletedList1.DataSource = ds;
            BulletedList1.DataTextField = "esalary";
            BulletedList1.DataBind();








        }
    }
}