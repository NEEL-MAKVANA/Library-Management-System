<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="LibraryManagementSystem.Views.Admin.Users" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <form class="row g-3">


    <div class="col-md-3">
    <label for="inputEmail4" class="form-label">User Name</label>
    <input type="text" class="form-control" id="UNameTb" runat="server">
  </div>

                  <div class="col-md-3">
    <label for="inputEmail4" class="form-label">User Email</label>
    <input type="text" class="form-control" id="EmailTb" runat="server">
  </div>
                <div class="col-md-3">
    <label for="inputEmail4" class="form-label">User Phone</label>
    <input type="text" class="form-control" id="PhoneTb" runat="server">
  </div>


  <div class="col-md-3">
    <label for="inputEmail4" class="form-label">User Password</label>
    <input type="text" class="form-control" id="PasswordTb" runat="server">
  </div>

  
  <div class="row mt-3">
       <label id="ErrMsg" class="text-danger text-center" runat="server" />
                    </label>
      <div class="col-4 d-grid">
                        <asp:Button ID="EditBtn" runat="server" Text="Edit User" class="btn btn-primary btn-block" OnClick="EditBtn_Click"/>
         
      </div>

                    <div class="col-4 d-grid">

                        <asp:Button ID="AddBtn" runat="server" Text="Add User" class="btn btn-primary btn-block" OnClick="AddBtn_Click" />

                    </div>

                    <div class="col-4 d-grid">
                        <asp:Button ID="DeleteBtn" runat="server" Text="Delete User" class="btn btn-primary btn-block" OnClick="DeleteBtn_Click" />

                    </div>
</div>
  
  
</form>

        </div>
        <div class="row">
            <h5 class="text-center">Users List</h5>
            <asp:GridView ID="UsersList" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="UsersList_SelectedIndexChanged" ></asp:GridView>

        </div>

    </div>
</asp:Content>
