using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace GYM_PROJECT_WDDN
{
    public partial class Login : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\GYM_PROJECT_WDDN.mdf;Integrated Security=True;Connect Timeout=30");        
        MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\Documents\GYM_PROJECT_WDDN.mdf;Integrated Security=True;Connect Timeout=30");            
            MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
            con.Open();
            MySqlCommand comm = new MySqlCommand("select * from [admin] where username =@username and password=@password", con);
            comm.Parameters.AddWithValue("username", username.Text);
            comm.Parameters.AddWithValue("password", password.Text);
            MySqlDataAdapter d = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            comm.ExecuteNonQuery();
            con.Close();

            if(dt.Rows.Count>0)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblerror.Text = "Username and Password are wrong.";
            }
        }
    }
}