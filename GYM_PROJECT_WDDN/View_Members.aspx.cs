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
    public partial class View_Members : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        void LoadRecord()
        {
            con.Open();
            MySqlCommand comm = new MySqlCommand("select * from users", con);
            MySqlDataAdapter d = new MySqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("admin_Reg.aspx");

        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            
            Response.Redirect("index.aspx");
        }
    }
}