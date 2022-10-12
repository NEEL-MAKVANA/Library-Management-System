<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="LibraryManagementSystem.Views.Admin.Books" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <form class="row g-3">


    <div class="col-md-4">
    <label for="inputEmail4" class="form-label">Books Code</label>
    <input type="text" class="form-control" id="BCodeTb" runat="server"/>
  </div>

                  <div class="col-md-4">
    <label for="inputEmail4" class="form-label">Book title</label>
    <input type="text" class="form-control" id="BTitleTb" runat="server"/>
  </div>
                <div class="col-md-4">
    <label for="inputEmail4" class="form-label">Author Name</label>
    <input type="text" class="form-control" id="BAuthorTb" runat="server"/>
  </div>


  <div class="col-md-4">
    <label for="inputEmail4" class="form-label">Books Publisher</label>
    <input type="text" class="form-control" id="BPublisherTb" runat="server"/>
  </div>



  <div class="col-md-4">
    <label for="inputEmail4" class="form-label">Books price</label>
    <input type="text" class="form-control" id="BPriceTb" runat="server"/>
  </div>


  <div class="col-md-4">
    <label for="inputEmail4" class="form-label">Books Quantity</label>
    <input type="text" class="form-control" id="BQtyTb" runat="server"/>
  </div>


   





               



    <div class="col-md-4">
   <label for="inputState" class="form-label">Category</label>
    <select class="form-select" id="BCatCb" runat="server">
      <option selected>Choose...</option>
      <option>Novels</option>
      <option>Programming</option>
      <option>Chemestry</option>
      <option>Life Style</option>
      <option>Other</option>

      
    </select>
  </div>
  
   <div class="row mt-3">
                    <label id="ErrMsg" class="text-danger text-center" runat="server" />
                    </label>
      <div class="col-4 d-grid">
                        <asp:Button ID="EditBtn" runat="server" Text="Edit Book" class="btn btn-primary btn-block" OnClick="EditBtn_Click"/>
         
      </div>

                    <div class="col-4 d-grid">

                        <asp:Button ID="AddBtn" runat="server" Text="Add Book" class="btn btn-primary btn-block" OnClick="AddBtn_Click"  />

                    </div>

                    <div class="col-4 d-grid">
                        <asp:Button ID="DeleteBtn" runat="server" Text="Delete Book" class="btn btn-primary btn-block" OnClick="DeleteBtn_Click" />

                    </div>
                </div>
                </form>
            </div>
       
        <div class="row">

            <h5 class="text-center">Books List</h5>
            <asp:GridView ID="BooksList" class="table table-bordered" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="BooksList_SelectedIndexChanged" ></asp:GridView>

        </div>

    </div>
</asp:Content>
