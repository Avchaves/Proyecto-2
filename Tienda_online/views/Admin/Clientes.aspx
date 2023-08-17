<%@ Page Title="" Language="C#" MasterPageFile="~/views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="Tienda_online.views.Admin.Clientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
    <div class="row">
        <div class="col"> <h3 class="text-center">Catalogo de Clientes</h3></div>
    </div>
    <div class="row">
    <div class="col-md-4">
        <div class="mb-3">
            <label for="" class="form-label text-success">Nombre</label>
            <input type="text" placeholder="Nombre"  id="nombreTb" runat="server" autocomplete="off" class="form-control"/>
        </div>
        <div class="mb-3">
            <label for="" class="form-label text-success">Apellido</label>
            <input type="text" placeholder="Apellido"  id="apellidoTb" runat="server" autocomplete="off" class="form-control"/>
        </div>
        <div class="mb-3">
            <label for="" class="form-label text-success">Direccion</label>
            <input type="text" placeholder="Direccion"  id="direccionTb" runat="server" autocomplete="off" class="form-control"/>
        </div>
          <div class="mb-3">
            <label for="" class="form-label text-success">Telefono</label>
            <input type="number" placeholder="Telefono"  id="telefonoTb" runat="server" autocomplete="off" class="form-control"/>           
        </div>
        <div class="row">
            <asp:Label runat="server" id="ErrMsg" Class="text-danger text-center"></asp:Label>
            <div class="col d-grid"> <asp:Button text="ACTUALIZAR" runat="server" Class="btn-warning btn-block btn"/></div>
            <div class="col d-grid"> <asp:Button text="GUARDAR" runat="server" Class="btn-success btn-block btn"/></div>
            <div class="col d-grid"> <asp:Button text="ELIMINAR" runat="server" Class="btn-danger btn-block btn"/></div>
        </div>


    </div>
         <div class="col-md-8">
              <asp:GridView ID="ListaClientes" runat="server" class="table table-bordered" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="true">
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
