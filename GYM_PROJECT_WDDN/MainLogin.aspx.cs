using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace GYM_PROJECT_WDDN
{
    public partial class MainLogin : System.Web.UI.Page { 
        
        MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
            con.Open();
            MySqlCommand comm = new MySqlCommand("select id,name,password from users where name=@name and password=@password", con);
            comm.Parameters.AddWithValue("name", txt_Username.Text);
            comm.Parameters.AddWithValue("password", txt_password.Text);
            comm.ExecuteNonQuery();
            MySqlDataAdapter d = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);


            //con.Close();

            if (dt.Rows.Count > 0)
            {
                string ID = " ";                
                var dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    ID = dr.GetString(0);
                }
                if (ID == "1")
                {
                    Session["id"] = ID;
                    Session["admin"] = "true";
                    Response.Redirect("admin_Reg.aspx");
                }
                else
                {
                    Session["id"] = ID;
                    Session["admin"] = "false";
                    Response.Redirect("Register.aspx");
                }
                dr.Close();
                con.Close();
            }
            else
            {
                lblerror.Text = "Username and Password are wrong.";
                con.Close();
            }
        }
    }
}