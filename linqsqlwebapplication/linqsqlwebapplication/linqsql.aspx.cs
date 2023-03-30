using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Data;

namespace linqsqlwebapplication
{

    public partial class linqsql : System.Web.UI.Page
    {
        int id;
        string name, role;
        float salary;
        employeeDataContext X = new employeeDataContext
            ("Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=ey;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var data = from s in X.employees
                       select s;
            GridView1.DataSource = data.ToList();
            GridView1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            id = int.Parse(TextBox5.Text);
            name = TextBox6.Text;
            var row = from s in X.employees
                      select s;
            foreach (employee s in row)
            {

                if (s.eid == id)
                {
                    s.ename =name;
                }
            }
            X.SubmitChanges();
            Response.Write("updated successfully");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            id= int.Parse(TextBox7.Text);
            var del = from s in X.employees
                      where s.eid == id
                      select s;

            X.employees.DeleteAllOnSubmit(del);
            X.SubmitChanges();
            Response.Write("deleted successfully");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = int.Parse(TextBox1.Text);
            name = TextBox2.Text;
            salary = float.Parse(TextBox3.Text);
            role = TextBox4.Text;



            employee etable = new employee();
            etable.eid = id;
            etable.ename = name;
            etable.esalary = salary;
            etable.erole = role;


            X.employees.InsertOnSubmit(etable);
            X.SubmitChanges();
            Response.Write("Inserted Successfully");
        }
    }
}