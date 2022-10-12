using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem.Views.Admin
{
    public partial class DashBoard : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
                Response.Redirect("login.aspx");
            Con = new Models.Functions();
            ShowIssueBook();

        }

        private void ShowIssueBook()
        {
            string Query = "select * from IssueTbl";
            IssueBookList.DataSource = Con.GetData(Query);
            IssueBookList.DataBind();
        }

        protected void IssueBookList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}