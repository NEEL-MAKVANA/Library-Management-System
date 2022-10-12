<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="LibraryManagementSystem.Views.Admin.Students" EnableEventValidation="false" %>

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
                    <input type="text" class="form-control" id="DepCb" runat="server">
                </div>

                 <div class="col-md-4">
                    <label for="inputEmail4" class="form-label">StudentID</label>
                    <input type="text" class="form-control" id="StIdTb" runat="server">
                </div>

                <div class="col-md-4">
                    <label for="inputEmail4" class="form-label">semester</label>
                    <select id="SemesterCb" class="form-select" runat="server">
                        <option selected="selected">Choose...</option>
                        <option>1</option>
                        <option>2</option>
                        <option>3</option>
                        <option>4</option>
                        <option>5</option>
                        <option>6</option>
                        <option>7</option>
                        <option>8</option>




                    </select>
                </div>

                <div class="col-md-4">
                    <label for="inputEmail4" class="form-label">Phone</label>
                    <input type="text" class="form-control" id="PhoneTb" runat="server" />
                </div>


                <div class="col-md-4">
                    <label for="inputEmail4" class="form-label">gender</label>
                    <select id="GenCb" runat="server" class="form-select">
                        <option selected="selected">Choose...</option>
                        <option>Male</option>
                        <option>Female</option>


                    </select>
                </div>















                <div class="row mt-3">
                    <label id="ErrMsg" class="text-danger text-center" runat="server" />
                    </label>
      <div class="col-4 d-grid">
                        <asp:Button ID="EditBtn" runat="server" Text="Edit Student" class="btn btn-primary btn-block" OnClick="EditBtn_Click"/>
         
      </div>

                    <div class="col-4 d-grid">

                        <asp:Button ID="AddBtn" runat="server" Text="Add Student" class="btn btn-primary btn-block" OnClick="AddBtn_Click" />

                    </div>

                    <div class="col-4 d-grid">
                        <asp:Button ID="DeleteBtn" runat="server" Text="Delete Student" class="btn btn-primary btn-block" OnClick="DeleteBtn_Click" />

                    </div>
                </div>


            </form>

        </div>
        <div class="row">
            <h5 class="text-center">Books List</h5>
            <asp:GridView ID="StudentsList" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="StudentsList_SelectedIndexChanged"></asp:GridView>
        </div>

    </div>
</asp:Content>
