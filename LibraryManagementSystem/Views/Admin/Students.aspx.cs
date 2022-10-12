using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem.Views.Admin
{
    public partial class Students : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
                Response.Redirect("login.aspx");
            Con = new Models.Functions();
            ShowStudent();
        }
        //method to display all the students

        private void ShowStudent()
        {
            string Query = "select * from StudentTbl";
            StudentsList.DataSource = Con.GetData(Query);
            StudentsList.DataBind();
        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {

            if (StNameTb.Value == "" || DepCb.Value == "" || PhoneTb.Value == "" || SemesterCb.Value == "Choose..." || PhoneTb.Value == "" || GenCb.Value == "Choose..." || StIdTb.Value == "")
            {
                ErrMsg.InnerHtml = "Missing Information!!";
            }
            else
            {
                try
                {
                    string SName = StNameTb.Value;
                    string Department = DepCb.Value;
                    string Semester = SemesterCb.Value;
                    string Phone = PhoneTb.Value;
                    string Gender = GenCb.Value;
                    string ClgId = StIdTb.Value;
                    string Query = "insert into StudentTbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, SName, Department, Semester, Phone, Gender,ClgId);
                    Con.SetData(Query);
                    ShowStudent();
                    ErrMsg.InnerText = "Student Recorded!";
                    StNameTb.Value = "";
                    DepCb.Value = "";
                    SemesterCb.Value = "Choose...";
                    PhoneTb.Value = "";
                    GenCb.Value = "Choose...";
                    StIdTb.Value = "";
                }
                catch(Exception Ex)
                {
                    ErrMsg.InnerText=Ex.Message;

                }
               
            }   

        }
        int Key = 0;
        protected void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StNameTb.Value = StudentsList.SelectedRow.Cells[2].Text;
            DepCb.Value = StudentsList.SelectedRow.Cells[3].Text;
            SemesterCb.Value = StudentsList.SelectedRow.Cells[4].Text;
            PhoneTb.Value = StudentsList.SelectedRow.Cells[5].Text;
            GenCb.Value = StudentsList.SelectedRow.Cells[6].Text;
            StIdTb.Value = StudentsList.SelectedRow.Cells[7].Text;
            if (StNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsList.SelectedRow.Cells[1].Text);
            }


        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Value == "" || DepCb.Value == "" || PhoneTb.Value == "" || SemesterCb.Value == "Choose..." || PhoneTb.Value == "" || GenCb.Value == "Choose..." || StIdTb.Value == "")
            {
                ErrMsg.InnerHtml = "Missing Information!!";
            }
            else
            {
                try
                {
                    string SName = StNameTb.Value;
                    string Department = DepCb.Value;
                    string Semester = SemesterCb.Value;
                    string Phone = PhoneTb.Value;
                    string Gender = GenCb.Value;
                    string ClgId = StIdTb.Value;
                    string Query = "update  StudentTbl set StName = '{0}',StDepartment='{1}',StSemester = '{2}',StPhone = '{3}',StGender = '{4}',ClgId = '{5}' where StId = {6}";
                    Query = string.Format(Query, SName, Department, Semester, Phone, Gender,ClgId, StudentsList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowStudent();
                    ErrMsg.InnerText = "Student Updated!";

                    StNameTb.Value="";
                     DepCb.Value="";
                    SemesterCb.Value= "Choose...";
                    PhoneTb.Value="";
                    GenCb.Value= "Choose...";
                    StIdTb.Value = "";


                }
                catch (Exception Ex)
                {
                    ErrMsg.InnerText = Ex.Message;

                }

            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

            if (StNameTb.Value == "" || DepCb.Value == "" || PhoneTb.Value == "" || SemesterCb.Value == "Choose..." || PhoneTb.Value == "" || GenCb.Value == "Choose..." || StIdTb.Value == "")
            {
                ErrMsg.InnerHtml = "Missing Information!!";
            }
            else
            {
                try
                {
                    string SName = StNameTb.Value;
                    string Department = DepCb.Value;
                    string Semester = SemesterCb.Value;
                    string Phone = PhoneTb.Value;
                    string Gender = GenCb.Value;
                    string ClgId = StIdTb.Value;
                    string Query = "Delete from StudentTbl  where StId = {0}";
                    Query = string.Format(Query,StudentsList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowStudent();
                    ErrMsg.InnerText = "Student Deleted!";
                    StNameTb.Value = "";
                    DepCb.Value = "";
                    SemesterCb.Value = "Choose...";
                    PhoneTb.Value = "";
                    GenCb.Value = "Choose...";
                    StIdTb.Value = "";
                }
                catch (Exception Ex)
                {
                    ErrMsg.InnerText = Ex.Message;

                }

            }
        }
    }



}
    
