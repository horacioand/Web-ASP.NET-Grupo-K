<%@ Page Title="Canje" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canjear.aspx.cs" Inherits="Main.Canjear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 style="justify-self: center" id="title"><%: Title %></h3>
    <hr />

    <div class="row" id="rowDivCanjear" visible="false" runat="server">
        <div class="col-sm"></div>
        <div class="col-sm d-flex flex-column align-items-center">
            <asp:Label CssClass="h5" ID="artSeleccionado" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnCambiarArticulo" OnClick="btnCambiarArticulo_Click" runat="server" Text="Cambiar" CssClass="btn btn-primary mb-2" />
            <asp:Label CssClass="h5" ID="lblExito" runat="server" Text="Confirmar canje?"></asp:Label>
            <asp:Button ID="btnContinuar" OnClick="btnContinuar_Click" runat="server" Text="Confirmar" CssClass="btn btn-primary mb-2" />
            <asp:Button ID="btnCancelar" OnClick="btnCancelar_Click" runat="server" Text="Cancelar" CssClass="btn btn-danger" />
        </div>
        <div class="col-sm"></div>
    </div>
    <div class="row" id="rowDivCodigo" runat="server">
        <div class="col-sm"></div>
        <div class="col-sm d-flex flex-column align-items-center">
            <asp:Label CssClass="h6" ID="lblInfo" runat="server" Text="Ingrese el codigo:"></asp:Label>
            <br />
            <asp:TextBox ID="tbCodigo" CssClass="form-control mb-2" runat="server"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" CssClass="" Text=""></asp:Label>
            <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" CssClass="btn btn-primary" />
        </div>
        <div class="col-sm"></div>
    </div>

    <!--Seccion oculta canje exitoso premio-->
    <div class="row" id="divCanjeExitoso" visible="false" runat="server">
        <div class="col-sm"></div>
        <div class="col-sm d-flex flex-column align-items-center">
            <asp:Label CssClass="h2" ID="lblCanjeExitoso" runat="server" Text="Artículo canjeado exitosamente!"></asp:Label>
            <asp:Button ID="btnPerfil" OnClick="btnPerfil_Click" runat="server" Text="Continuar" CssClass="btn btn-primary" />
        </div>
        <div class="col-sm"></div>
    </div>
</asp:Content>
