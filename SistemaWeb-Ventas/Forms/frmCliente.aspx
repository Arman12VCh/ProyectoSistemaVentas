<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmCliente.aspx.vb" Inherits="SistemaWeb_Ventas.frmCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<div class="container">
    <div class="row">        
        <h2>Formulario Cliente</h2>
        <form class="form-horizontal form-label-left" method="post" action="#">
            <div class="col-md-6">
            <div class="item form-group">
                <label class="col-form-label col-md-12 col-sm-12 label-align">Nombre<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 ">
                    <%--<input type="text" id="txtNombre" name="txtNombre" required="required" class="form-control " tabindex="1">--%>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" TabIndex="1" Width="777px"></asp:TextBox>
               </div>
            </div>
            <div class="item form-group">
                <label class="col-form-label col-md-12 col-sm-12 label-align">Apellido Paterno<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 ">
                    <asp:TextBox ID="txtApePaterno" runat="server" CssClass="form-control" TabIndex="2" Width="777px"></asp:TextBox>
                </div>
            </div>
            <div class="item form-group">
                <label class="col-form-label col-md-12 col-sm-12 label-align">Apellido Materno<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 ">
                    <asp:TextBox ID="txtApeMaterno" runat="server" CssClass="form-control" TabIndex="3" Width="777px"></asp:TextBox>
                </div>
            </div>
                <div class="item form-group">
                <label class="col-form-label col-md-12 col-sm-12 label-align">DNI<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 ">
                    <asp:TextBox ID="txtDNI" runat="server" CssClass="form-control" TabIndex="4" Width="777px"></asp:TextBox>
                </div>
            </div>
                <div class="item form-group">
                <label class="col-form-label col-md-12 col-sm-12 label-align">Género<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 ">
                    <asp:TextBox ID="txtGenero" runat="server" CssClass="form-control" TabIndex="5" Width="777px"></asp:TextBox>
                </div>
            </div>
                </div>
            <div class="col-md-6">
            <div class="item form-group">
                <label class="col-form-label col-md-12 col-sm-12 label-align">Teléfono<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 ">
                    <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TabIndex="6" Width="777px"></asp:TextBox>
                </div>
            </div>
            <div class="item form-group">
                <label class="col-form-label col-md-12 col-sm-12 label-align">Dirección<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 ">
                    <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" TabIndex="7" Width="777px"></asp:TextBox>
                </div>
            </div>
            <div class="item form-group">
                <label class="col-form-label col-md-12 col-sm-12 label-align">Corro electrónico<span class="required">*</span>
                </label>
                <div class="col-md-6 col-sm-6 ">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TabIndex="8" Width="777px"></asp:TextBox>
                </div>
            </div>
            </div>
            <div class="row">            
                <div class="item form-group">
                    <div class="col align-self-center">
                        <asp:Button ID="btnNuevo" runat="server" Height="36px" Text="Nuevo Cliente" Width="110px" BackColor="#0033CC" ForeColor="White" TabIndex="7" />
                        <asp:Button ID="btnEditar" runat="server" Height="36px" Text="Editar" Width="110px" BackColor="#0066CC" ForeColor="White" TabIndex="8" />
                        <asp:Button ID="btnEliminar" runat="server" Height="36px" Text="Eliminar" Width="110px" BackColor="Red" ForeColor="White" TabIndex="9" />
                    </div>
                </div>
            </div>
        </form>
    </div>    
    <div class="row">

        <table class="table">
          <thead class="thead-dark">
            <tr>
              <th scope="col">ID</th>
              <th scope="col">Nombre</th>
              <th scope="col">Teléfono</th>
              <th scope="col">Dirección</th>
              <th scope="col">Email</th>
            </tr>
          </thead>
          <tbody>
          </tbody>
        </table>
    </div>
    <asp:GridView ID="GridView1" runat="server" Width="803px">
    </asp:GridView>
</div>
</asp:Content>
