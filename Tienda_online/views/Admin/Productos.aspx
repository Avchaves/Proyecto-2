<%@ Page Title="" Language="C#" MasterPageFile="~/views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Tienda_online.views.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
<div class="container-fluid">
    <div class="row">
        <div class="col"> <h3 class="text-center">Catalogo de Productos</h3></div>
    </div>
    <div class="row">
    <div class="col-md-4">
        <div class="mb-3">
            <label for="" class="form-label text-success">Nombre</label>
            <input type="text" placeholder="Nombre" id="nombreTb" runat="server" autocomplete="off" class="form-control"/>
        </div>
        <div class="mb-3">
            <label for="" class="form-label text-success">Categoria</label>
            <asp:DropDownList  id="categoriaTb" runat="server" class="form-control"></asp:DropDownList>
        </div>
        <div class="mb-3">
            <label for="" class="form-label text-success">Precio</label>
            <input type="text" placeholder="Precio"  id="precioTb" runat="server"  autocomplete="off" class="form-control"/>
        </div>
        <div class="mb-3">
            <label for="" class="form-label text-success">Cantidad</label>
            <input type="text" placeholder="Cantidad"  id="cantidadTb" runat="server"  autocomplete="off" class="form-control"/>
        </div>
          <div class="mb-3">
            <label for="" class="form-label text-success">Proveedor</label>
           <asp:DropDownList id="proveedorTb" runat="server" class="form-control"></asp:DropDownList>
        </div>
        <div class="row">
            <asp:Label runat="server" id="ErrMsg" Class="text-danger text-center"></asp:Label>
            <div class="col d-grid"> <asp:Button Text="ACTUALIZAR" runat="server" ID="ACTUALIZARBtn" Class="btn-warning btn-block btn" OnClick="ACTUALIZARBtn_Click" /></div>
            <div class="col d-grid"> <asp:Button Text="GUARDAR" runat="server" ID="GUARDARBtn" Class="btn-success btn-block btn" OnClick="GUARDARBtn_Click" /></div>
            <div class="col d-grid"> <asp:Button text="ELIMINAR" runat="server" ID="ELIMINARBtn" Class="btn-danger btn-block btn"/></div>
        </div>


    </div>
         <div class="col-md-8">
             <asp:GridView ID="ListaProductos" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true">
                 <AlternatingRowStyle BackColor="White" />
                 <EditRowStyle BackColor ="#7C6F57" />
                 <FooterStyle BackColor="#1C5E55" Font-Bold="true" ForeColor="White" />
                 <HeaderStyle  BackColor="Teal" Font-Bold="false" ForeColor="White"/>
                 <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle  BackColor="#E3EAEB"/>
                 <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="true" ForeColor="#333333" />
                 <SortedAscendingCellStyle BackColor= "#F8FAFA" />
                 <SortedAscendingHeaderStyle BackColor="#246B61" />
                 <SortedDescendingCellStyle BackColor="#D4DFE1" />
                 <SortedAscendingHeaderStyle BackColor="#15524A" />
             </asp:GridView>

         </div>
     </div>
</div>
</asp:Content>
