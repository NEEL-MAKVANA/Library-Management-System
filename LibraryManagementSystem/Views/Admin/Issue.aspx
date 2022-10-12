<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Issue.aspx.cs" Inherits="LibraryManagementSystem.Views.Admin.Issue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container-fluid">
        <div class="row">
            <form class="row g-3">


                <div class="col-md-4">
                    <label for="inputEmail4" class="form-label">Student Name</label>
                    <input type="text" class="form-control" id="StNameTb" runat="server">
                </div>

                <div class="col-md-4">
                    <label for="inputEmail4" class="form-label">Department</label>
                    <input type="text" class="form-control" id="StDeptTb" runat="server">
                </div>

                 <div class="col-md-4">
                    <label for="inputEmail4" class="form-label">StudentID</label>
                    <input type="text" class="form-control" id="StIdTb" runat="server">
                </div>


              

                <div class="col-md-4">
                    <label for="inputEmail4" class="form-label">Phone</label>
                    <input type="text" class="form-control" id="StPhoneTb" runat="server" />
                </div>

                 <div class="col-md-4">
    <label for="inputEmail4" class="form-label">Books Code</label>
    <input type="text" class="form-control" id="StBCodeTb" runat="server"/>
  </div>

                  <div class="col-md-4">
    <label for="inputEmail4" class="form-label">Book title</label>
    <input type="text" class="form-control" id="StBTitleTb" runat="server"/>
  </div>
               















                <div class="row mt-3">
                    <label id="ErrMsg" class="text-danger text-center" runat="server" />
                    </label>
      <div class="col-4 d-grid">
                        <asp:Button ID="EditBtn" runat="server" Text="Edit Issued Book" class="btn btn-primary btn-block" OnClick="EditBtn_Click" />
         
      </div>

                    <div class="col-4 d-grid">

                        <asp:Button ID="AddBtn" runat="server" Text="Issue Book" class="btn btn-primary btn-block" OnClick="AddBtn_Click"/>

                    </div>

                    <div class="col-4 d-grid">
                        <asp:Button ID="DeleteBtn" runat="server" Text="Delete Issued Book" class="btn btn-primary btn-block" OnClick="DeleteBtn_Click" />

                    </div>
                </div>


            </form>

        </div>
        <div class="row">
            <h5 class="text-center">Issued Books List</h5>
            <asp:GridView ID="IssueBookList" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="IssueBookList_SelectedIndexChanged" /></asp:GridView>
        </div>

    </div>


</asp:Content>
