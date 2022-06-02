using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace GYM_PROJECT_WDDN
{
    public partial class admin_Reg : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
        protected void Page_Load(object sender, EventArgs e)
        {
            if(txt_id.Text == "")
            {
                btn_cancel.Visible = false;
                btn_update.Visible = false;
            }   
        }

        protected void txt_id_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btn_view_Members_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Members.aspx");
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
            con.Open();
            MySqlCommand comm = new MySqlCommand("insert into users (name,address,contact,city,age,password,auth) values('" + txt_name.Text + "','" + txt_Address.Text + "','" + Int64.Parse(txt_contact.Text) + "','" + ddl_city.SelectedValue + "','" + int.Parse(txt_age.Text) + "','" + txt_pwd.Text + "','false')", con);
            comm.ExecuteNonQuery();

            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Inserted.');", true);
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand comm = new MySqlCommand("update users set name='" + txt_name.Text + "',address='" + txt_Address.Text + "', city='" + ddl_city.SelectedValue.ToString() + "', contact='" + Int64.Parse(txt_contact.Text) + "', age='" + int.Parse(txt_age.Text) + "', password='" + txt_pwd.Text + "'  where id= '" + int.Parse(txt_id.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Updated.');", true);
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            if(txt_id.Text != "")
            {
                con.Open();
                MySqlCommand comm = new MySqlCommand("delete from users where Id= '" + int.Parse(txt_id.Text) + "' ;", con);
                comm.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Deleted.');", true);
            }
            
            Response.Redirect("View_Members.aspx");
        }

        protected void txt_id_TextChanged1(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "true")
            {
                con.Open();
                MySqlCommand comm = new MySqlCommand("select * from users where id=@id", con);
                comm.Parameters.AddWithValue("id", txt_id.Text);
                comm.ExecuteNonQuery();

                var dr = comm.ExecuteReader();


                if (dr.HasRows)
                {
                    dr.Read();
                    txt_name.Text = dr.GetString(1);
                    txt_Address.Text = dr.GetString(2);
                    txt_contact.Text = dr.GetString(3);
                    ddl_city.SelectedValue = dr.GetString(4);
                    txt_age.Text = dr.GetString(5);
                    lb_pwd.Text = dr.GetString(6);          

                }



            }
            if(txt_id.Text != "")
            {
                btn_cancel.Visible = true;
                btn_update.Visible = true;
            }else
            {
                txt_name.Text = "";
                txt_Address.Text = "";
                txt_contact.Text = "";
                txt_age.Text = "";
                lb_pwd.Text = "";

            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            
            Response.Redirect("index.aspx");
        }
    }
}