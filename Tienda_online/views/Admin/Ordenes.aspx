<%@ Page Title="" Language="C#" MasterPageFile="~/views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Ordenes.aspx.cs" Inherits="Tienda_online.views.Admin.Ordenes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col"> <h3 class="text-center">Categoria de Productos</h3></div>
    </div>
    <div class="row">
    <div class="col-md-4">
        <div class="mb-3">
            <label for="" class="form-label text-success">IdClientes</label>
            <input type="text" placeholder="Id del cliente" autocomplete="off" class="form-control" runat="server" id="idclientes"/>
        </div>
         <div class="mb-3">
            <label for="" class="form-label text-success">Idorden</label>
            <input type="text" placeholder="Id de la orden" autocomplete="off" class="form-control" runat="server" id="idorden"/>
        </div>
         <div class="mb-3">
            <label for="" class="form-label text-success">Fecha</label>
            <input type="text" placeholder="Fecha" autocomplete="off" class="form-control" runat="server" id="fecha"/>
        </div>
        <div class="mb-3">
            <label for="" class="form-label text-success">Total</label>
            <input type="text" placeholder="Total" autocomplete="off" class="form-control" runat="server" id="total"/>
        </div>
        
        <div class="row"> 
            <asp:Label runat="server" id="ErrMsg" Class="text-danger"></asp:Label>
            <div class="col d-grid"> <asp:Button runat="server" Text="ACTUALIZAR"  Class="btn-warning btn-block btn" OnClick="ACTUALIZARBtn_Click" /></div>
            <div class="col d-grid"> <asp:Button runat="server" Text="GUARDAR"   Class="btn-success btn-block btn" OnClick="GUARDARBtn_Click" /></div>
            <div class="col d-grid"> <asp:Button runat="server" Text="ELIMINAR"  Class="btn-danger btn-block btn" OnClick="ELIMINARBtn_Click" /></div>
        </div>


    </div>
         <div class="col-md-8">
             <asp:GridView ID="ListaCategorias" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true">
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
