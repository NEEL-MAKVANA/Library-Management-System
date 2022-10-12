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
    public partial class Issue : System.Web.UI.Page
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
       
       

        protected void AddBtn_Click(object sender, EventArgs e)
        {

            string id = StIdTb.Value;
            string name = StNameTb.Value;
            string query = "SELECT * FROM StudentTbl WHERE StName='" + name + "' and ClgId='" + id + "'";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["UserConnection"].ConnectionString;
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (!rdr.Read())
            {
                ErrMsg.InnerText = "Student not found!!";
            }

            else
            {
                rdr.Close();
                conn.Close();
                // Book code checking
                string bookCode = StBCodeTb.Value;
                query = "SELECT * FROM BookTbl WHERE BCode='" + bookCode + "'";
                cmd = new SqlCommand(query, conn);
                conn.Open();
                rdr = cmd.ExecuteReader();

                if (!rdr.Read())
                {
                    ErrMsg.InnerText = "Book not found!!";
                }

                else
                {
                    if (StBCodeTb.Value != "" && StNameTb.Value != "" && StDeptTb.Value != "" && StBTitleTb.Value != "" && StIdTb.Value != "" && StPhoneTb.Value != "")
                    {
                        try
                        {
                            string student_name = StNameTb.Value;
                            string student_dept = StDeptTb.Value;
                            string student_id = StIdTb.Value;
                            string student_phone = StPhoneTb.Value;
                            string book_code = StBCodeTb.Value;
                            string book_title = StBTitleTb.Value;





                            string Query = "insert into IssueTbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                            Query = String.Format(Query, student_name, student_dept, student_id, student_phone, book_code, book_title);
                            Con.SetData(Query);
                            ErrMsg.InnerText = "Book Issued Successfully";

                            ShowIssueBook();

                            StNameTb.Value = "";
                            StDeptTb.Value = "";
                            StIdTb.Value = "";
                            StPhoneTb.Value = "";
                            StBCodeTb.Value = "";
                            StBTitleTb.Value = "";
                        }


                        catch (Exception Ex)
                        {
                            ErrMsg.InnerText = Ex.Message;

                        }
                    }
                    else
                    {
                        ErrMsg.InnerText = "Missing Information!!";
                    }
                }
            }

            rdr.Close();
            conn.Close();

        }

        
        protected void IssueBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StNameTb.Value = IssueBookList.SelectedRow.Cells[1].Text;
            StDeptTb.Value = IssueBookList.SelectedRow.Cells[2].Text;
            StIdTb.Value = IssueBookList.SelectedRow.Cells[3].Text;
            StPhoneTb.Value = IssueBookList.SelectedRow.Cells[4].Text;
            StBCodeTb.Value = IssueBookList.SelectedRow.Cells[5].Text;
            StBTitleTb.Value = IssueBookList.SelectedRow.Cells[6].Text;
           
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            if (StBCodeTb.Value != "" && StNameTb.Value != "" && StDeptTb.Value != "" && StBTitleTb.Value != "" && StIdTb.Value != "" && StPhoneTb.Value != "")
            {
                try
                {
                    string student_name = StNameTb.Value;
                    string student_dept = StDeptTb.Value;
                    string student_id = StIdTb.Value;
                    string student_phone = StPhoneTb.Value;
                    string book_code = StBCodeTb.Value;
                    string book_title = StBTitleTb.Value;





                    string Query = "Update IssueTbl set StName= '{0}',StDept='{1}',StId='{2}',StPhone='{3}',BCode='{4}',BTitle='{5}'";
                    Query = String.Format(Query, student_name, student_dept, student_id, student_phone, book_code, book_title);
                    Con.SetData(Query);
                    ErrMsg.InnerText = "Issued Book Update Successfully";

                    ShowIssueBook();

                    StNameTb.Value = "";
                    StDeptTb.Value = "";
                    StIdTb.Value = "";
                    StPhoneTb.Value = "";
                    StBCodeTb.Value = "";
                    StBTitleTb.Value = "";
                }


                catch (Exception Ex)
                {
                    ErrMsg.InnerText = Ex.Message;

                }
            }
            else
            {
                ErrMsg.InnerText = "Missing Information!!";
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (StBCodeTb.Value != "" && StNameTb.Value != "")
            {
                try
                {
                    string student_name = StNameTb.Value;
                    string student_dept = StDeptTb.Value;
                    string student_id = StIdTb.Value;
                    string student_phone = StPhoneTb.Value;
                    string book_code = StBCodeTb.Value;
                    string book_title = StBTitleTb.Value;
                   



                    string Query = "delete from IssueTbl where StId={0}";
                    Query = String.Format(Query, student_id);
                    Con.SetData(Query);
                    ErrMsg.InnerText = "Issued book delete Successfully";

                    ShowIssueBook();

                    StNameTb.Value = "";
                    StDeptTb.Value = "";
                    StIdTb.Value = "";
                    StPhoneTb.Value = "";
                    StBCodeTb.Value = "";
                    StBTitleTb.Value = "";
                }


                catch (Exception Ex)
                {
                    ErrMsg.InnerText = Ex.Message;

                }
            }
            else
            {
                ErrMsg.InnerText = "Missing Information!!";
            }
        }

       
    }
}