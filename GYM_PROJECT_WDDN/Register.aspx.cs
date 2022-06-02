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
    public partial class Register : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
        int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_cancel.Visible = false;
            btn_update.Visible = false;
            txt_id.Visible = false;
            if (Session["id"] != null) {
                btn_submit.Visible = false;
                txt_id.Text = Session["id"].ToString();
                //btn_logout.Style["visibility"] = "hidden";
                btn_logout.Visible = true;
                btn_cancel.Visible = true;
                btn_update.Visible = true;
                flag = 1;
                btn_cancel_simple.Visible = false;

                if(Session["admin"].ToString() == "false")
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

                    }


                    con.Close();
                }
            }else
            {
                btn_logout.Visible = false;
                btn_cancel_simple.Visible = true;


            }

            
            
        }

        

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(@"Server=127.0.0.1;User=root;Database=gym;Port=3306;Password=;SSL Mode=None");
            con.Open();
            MySqlCommand comm = new MySqlCommand("insert into users (name,address,contact,city,age,password,auth) values('" + txt_name.Text + "','" + txt_Address.Text + "','" + Int64.Parse(txt_contact.Text) + "','" + ddl_city.SelectedValue + "','" + int.Parse(txt_age.Text) + "','" + txt_pwd.Text + "','false')", con);
            comm.ExecuteNonQuery();

            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Inserted.');", true);
            Response.Redirect("MainLogin.aspx");
            
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            
                btn_update.Visible = true;
                con.Open();
                MySqlCommand comm = new MySqlCommand("update users set name='" + txt_name.Text + "',address='" + txt_Address.Text + "', city='" + ddl_city.SelectedValue.ToString() + "', contact='" + Int64.Parse(txt_contact.Text) + "', age='" + int.Parse(txt_age.Text) + "', password='" + txt_pwd.Text + "'  where id= '" + int.Parse(txt_id.Text) + "'", con);
                comm.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Updated.');", true);
            
            
        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
           
            
                
                con.Open();
                MySqlCommand comm = new MySqlCommand("delete from users where Id= '" + int.Parse(txt_id.Text) + "' ;", con);
                comm.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Record Deleted.');", true);
                Session.Abandon();
                Response.Redirect("index.aspx");


        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            
            Response.Redirect("index.aspx");
        }

        protected void btn_cancel_simple_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}