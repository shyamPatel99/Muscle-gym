using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace GYM_PROJECT_WDDN
{
    public partial class Home : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\GYM_PROJECT_WDDN.mdf;Integrated Security=True;Connect Timeout=30");       
        MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
              // LoadRecord();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\GYM_PROJECT_WDDN.mdf;Integrated Security=True;Connect Timeout=30");            
            MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
            con.Open();
            MySqlCommand comm = new MySqlCommand("insert into Members values('" + TextBox6.Text + "','" + TextBox1.Text + "','" + DropDownList1.SelectedValue + "','" + int.Parse(TextBox5.Text) + "','" + int.Parse(TextBox3.Text) + "','" + TextBox4.Text + "')", con);
            comm.ExecuteNonQuery();
            //LoadRecord();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Inserted.');", true);
            //Response.Redirect("view.aspx");
        }

        /*void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select * from Members", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }*/

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Members.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand comm = new MySqlCommand("delete Members where Id= '"+ int.Parse(TextBox6.Text) +"'", con);
            comm.ExecuteNonQuery();
            //LoadRecord();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Deleted.');", true);
            //Response.Redirect("view.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand comm = new MySqlCommand("update Members set Name='"+TextBox1.Text+ "', City='" + DropDownList1.SelectedValue + "', Contact='" + int.Parse(TextBox5.Text) + "', Age='" + int.Parse(TextBox3.Text) + "', Email='" + TextBox4.Text + "' where Id= '"+int.Parse(TextBox6.Text)+"'", con);
            comm.ExecuteNonQuery();
            //LoadRecord();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Updated.');", true);
            
        }
    }
}