<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Main.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col d-flex justify-content-end">
            <asp:Button ID="btnCerrarSesion" CssClass="btn btn-danger" Text="Cerrar Sesión" OnClick="btnCerrarSesion_Click" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-2"></div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label ID="lblNombre" CssClass="form-label" runat="server" Text="Nombre:"></asp:Label>
                <asp:TextBox ID="tbNombre" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblApellido" CssClass="form-label" runat="server" Text="Apellido:"></asp:Label>
                <asp:TextBox ID="tbApellido" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblEmail" CssClass="form-label" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="tbEmail" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblDireccion" CssClass="form-label" runat="server" Text="Direccion:"></asp:Label>
                <asp:TextBox ID="tbDireccion" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblCiuadad" CssClass="form-label" runat="server" Text="Ciudad:"></asp:Label>
                <asp:TextBox ID="tbCiudad" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblCP" CssClass="form-label" runat="server" Text="Codigo Postal:"></asp:Label>
                <asp:TextBox ID="tbCP" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="col-2"></div>
        <div class="col-3">
            <div class="mb-3">
                <!--
                //
                //CUPONES
                //
                    -->
                <asp:Label ID="Label1" CssClass="form-label" runat="server" Text="CUPONES:"></asp:Label>
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="col-2"></div>
    </div>
</asp:Content>
