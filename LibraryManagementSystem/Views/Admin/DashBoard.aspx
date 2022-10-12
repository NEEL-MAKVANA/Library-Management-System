<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="LibraryManagementSystem.Views.Admin.DashBoard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
            <h5 class="text-center">Issued Books List</h5>
            <asp:GridView ID="IssueBookList" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="IssueBookList_SelectedIndexChanged"/></asp:GridView>
        </div>
</asp:Content>
