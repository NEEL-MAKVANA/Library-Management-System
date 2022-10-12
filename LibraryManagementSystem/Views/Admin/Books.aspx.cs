using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] == null)
                Response.Redirect("login.aspx");
            Con = new Models.Functions();
            ShowBooks();
            
        }

        private void ShowBooks()
        {
            string Query = "select * from BookTbl";
            BooksList.DataSource = Con.GetData(Query);
            BooksList.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            if(BCodeTb.Value != "" && BTitleTb.Value != "" && BAuthorTb.Value!="" && BPublisherTb.Value != "" && BPriceTb.Value!="" && BQtyTb.Value != "" && BCatCb.Value != "Choose...")
            {
                try
                {
                    string BCode = BCodeTb.Value;
                    string BTitle = BTitleTb.Value;
                    string BAuth=BAuthorTb.Value;
                    string BPub = BPublisherTb.Value;
                    string BPrice = BPriceTb.Value;
                    string Qty = BQtyTb.Value;
                   
                    string Cat = BCatCb.Value;


                    
                    string Query = "insert into BookTbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                    Query = String.Format(Query,BCode,BTitle,BAuth,BPub,BPrice,Qty,Cat);
                    Con.SetData(Query);
                    ErrMsg.InnerText = "Book Added Successfully";
                    ShowBooks();
                    BCodeTb.Value = "";
                    BTitleTb.Value = "";
                    BAuthorTb.Value = "";
                    BPublisherTb.Value = "";
                    BPriceTb.Value = "";
                    BQtyTb.Value = "";
                    BCatCb.Value = "Choose...";
                }
                catch(Exception Ex)
                {
                    ErrMsg.InnerText = Ex.Message;
                   
                }
            }
            else
            {
                ErrMsg.InnerText = "Missing Information!!";
            }

        }

       

       
        string BCode;
        protected void BooksList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTitleTb.Value = BooksList.SelectedRow.Cells[2].Text;
            BAuthorTb.Value = BooksList.SelectedRow.Cells[3].Text;
            BPublisherTb.Value = BooksList.SelectedRow.Cells[4].Text;
            BPriceTb.Value = BooksList.SelectedRow.Cells[5].Text;
            BQtyTb.Value = BooksList.SelectedRow.Cells[6].Text;
            BCatCb.Value = BooksList.SelectedRow.Cells[7].Text;

            if (BTitleTb.Value == "")
            {
                BCode = "";
            }
            else
            {
                BCode = BooksList.SelectedRow.Cells[1].Text;
            }
        }



        protected void EditBtn_Click(object sender, EventArgs e)
        {


            if (BCodeTb.Value != "" && BTitleTb.Value != "" && BAuthorTb.Value != "" && BPublisherTb.Value != "" && BPriceTb.Value != "" && BQtyTb.Value != "" && BCatCb.Value != "Choose...")
            {
                try
                {
                   // string BCode = BCodeTb.Value;
                    string BTitle = BTitleTb.Value;
                    string BAuth = BAuthorTb.Value;
                    string BPub = BPublisherTb.Value;
                    string BPrice = BPriceTb.Value;
                    string Qty = BQtyTb.Value;

                    string Cat = BCatCb.Value;



                    string Query = "Update BookTbl set BTitle='{0}',BAuthor='{1}',BPublisher='{2}',BPrice='{3}',BQty='{4}',Category='{5}'where BCode='{6}'";
                    Query = String.Format(Query, BTitle, BAuth, BPub, BPrice, Qty, Cat, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ErrMsg.InnerText = "Book Update Successfully";
                    ShowBooks();

                   BTitleTb.Value="";
                   BAuthorTb.Value="";
                    BPublisherTb.Value="";
                    BPriceTb.Value = "";
                     BQtyTb.Value = "";

                    BCatCb.Value = "Choose...";
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

            if ( BTitleTb.Value != "" && BAuthorTb.Value != "" && BPublisherTb.Value != "" && BPriceTb.Value != "" && BQtyTb.Value != "" && BCatCb.Value != "Choose...")
            {
                try
                {
                    


                    string Query = "Delete from BookTbl where BCode = '{0}'";
                    Query = String.Format(Query, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ErrMsg.InnerText = "Book Deleted Successfully";
                    ShowBooks();
                    BTitleTb.Value = "";
                    BAuthorTb.Value = "";
                    BPublisherTb.Value = "";
                    BPriceTb.Value = "";
                    BQtyTb.Value = "";
                    BCatCb.Value = "";
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