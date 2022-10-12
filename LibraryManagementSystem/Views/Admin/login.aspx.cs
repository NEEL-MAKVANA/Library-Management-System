using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace LibraryManagementSystem.Views.Admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginClick(object sender, EventArgs e)
        {
            msg.Text = "";
            msg.Visible = false;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["UserConnection"].ConnectionString;

            try
            {
                using (conn)
                {
                    string uname = textBoxUsername.Text;
                    string pass = textBoxPassword.Text;
                    string query = "SELECT * FROM Users WHERE Name='" + uname + "' and Password='" + pass + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Session["UserId"] = rdr["Id"];
                        msg.Visible = true;
                        msg.Text = "Login Successfully ...";
                        msg.ForeColor = System.Drawing.Color.Green;
                       // Response.Write("<script>alert('User details saved successfully');</script>");
                        Response.Redirect("Home.aspx");
                    }

                    else
                    {
                        msg.Visible = true;
                        msg.Text = "Username & Password is not correct, Please try again ...!";
                        msg.ForeColor = System.Drawing.Color.Red;
                    }

                    rdr.Close();
                    conn.Close();
                }
            }

            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }
    }
}