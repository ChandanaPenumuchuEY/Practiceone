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
    public partial class records : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog=ey;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            SqlDataAdapter a = new SqlDataAdapter("select * from employee", con);
            DataSet ds = new DataSet();
            a.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            SqlCommand x = new SqlCommand("select * from employee", con);
            SqlDataReader r = x.ExecuteReader();
            while(r.Read())
            {
                Response.Write("ID : " + r["eid"] + "  NAME " + r["ename"]+"\n");
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(eid.Text);
            String name = ename.Text;
            SqlCommand cmd = new SqlCommand("insert into employee values('" + id + "','" + name + "',87679.00,'Software')", con);
            cmd.ExecuteNonQuery();
            Response.Write("INSERTED SUCCESFULLY");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(eidd.Text);
            SqlCommand del = new SqlCommand("delete from employee where eid='"+id+"'",con);
            del.ExecuteNonQuery();
            Response.Write("DELETED SUCCESFULLY");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(TextBox1.Text);
            string name = TextBox2.Text;
            SqlCommand upd = new SqlCommand("update employee  set ename='" + name + "' where eid='" + id + "'", con);
            upd.ExecuteNonQuery();
            Response.Write("UPDATED SUCCESFULLY");
        }
    }
}