using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem.Views.Admin
{
    public partial class Users : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
                Response.Redirect("login.aspx");
            Con = new Models.Functions();
            ShowUsers();
        }

        private void ShowUsers()
        {
            string Query = "select * from UserTbl";
            UsersList.DataSource = Con.GetData(Query);
            UsersList.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {

            if (UNameTb.Value == "" || EmailTb.Value =="" || PhoneTb.Value == "" || PasswordTb.Value == "")
            {
                ErrMsg.InnerHtml = "Missing Information!!";
            }
            else
            {
                try
                {
                    string UName = UNameTb.Value;
                    string UEmail = EmailTb.Value;
                    string UPhone = PhoneTb.Value;
                    string UPassword = PasswordTb.Value;
                   
                    string Query = "insert into UserTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, UName, UEmail, UPhone, UPassword);
                    Con.SetData(Query);
                    ShowUsers();
                    ErrMsg.InnerText = "User Recorded!";

                    UNameTb.Value="";
                     EmailTb.Value="";
                     PhoneTb.Value="";
                    PasswordTb.Value = "";


                }
                catch (Exception Ex)
                {
                    ErrMsg.InnerText = Ex.Message;

                }

            }
        }
        int Key=0;
        protected void UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UNameTb.Value = UsersList.SelectedRow.Cells[2].Text;
            EmailTb.Value = UsersList.SelectedRow.Cells[3].Text;
            PhoneTb.Value = UsersList.SelectedRow.Cells[4].Text;
            PasswordTb.Value = UsersList.SelectedRow.Cells[5].Text;
            if (UNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(UsersList.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || PasswordTb.Value == "")
            {
                ErrMsg.InnerHtml = "Missing Information!!";
            }
            else
            {
                try
                {
                    string UName = UNameTb.Value;
                    string UEmail = EmailTb.Value;
                    string UPhone = PhoneTb.Value;
                    string UPassword = PasswordTb.Value;

                    string Query = "update UserTbl set UName='{0}',UEmail='{1}',UPhone='{2}',UPassword='{3}' where UId = {4}";
                    Query = string.Format(Query, UName, UEmail, UPhone, UPassword, UsersList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowUsers();
                    ErrMsg.InnerText = "User Updated!";

                    UNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    PasswordTb.Value = "";


                }
                catch (Exception Ex)
                {
                    ErrMsg.InnerText = Ex.Message;

                }

            }

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (UNameTb.Value == "" )
            {
                ErrMsg.InnerHtml = "Missing Information!!";
            }
            else
            {
                try
                {
                    string UName = UNameTb.Value;
                    string UEmail = EmailTb.Value;
                    string UPhone = PhoneTb.Value;
                    string UPassword = PasswordTb.Value;

                    string Query = "delete from UserTbl where UId = {0}";
                    Query = string.Format(Query, UsersList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowUsers();
                    ErrMsg.InnerText = "User Deleted!";

                    UNameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    PasswordTb.Value = "";


                }
                catch (Exception Ex)
                {
                    ErrMsg.InnerText = Ex.Message;

                }

            }
        }
    }
}