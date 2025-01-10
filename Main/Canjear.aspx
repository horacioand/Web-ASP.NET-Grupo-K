<%@ Page Title="Canje" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canjear.aspx.cs" Inherits="Main.Canjear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 style="justify-self: center" id="title"><%: Title %></h3>
    <div class="row" id="rowDivCodigo" runat="server">
        <div class="col-sm"></div>
        <div class="col-sm d-flex flex-column align-items-center">
            <asp:Label CssClass="h6" ID="lblInfo" runat="server" Text="Ingrese el codigo:"></asp:Label>
            <br />
            <asp:TextBox ID="tbCodigo" CssClass="form-control mb-2" runat="server"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" CssClass="" Text=""></asp:Label>
            <asp:Label CssClass="h5" ID="lblConfirmar" Visible="false" runat="server" Text="Confirmar canje?"></asp:Label>
            <asp:Label CssClass="h5" ID="lblArticulo" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnPremio" OnClick="btnPremio_Click" Visible="false" CssClass="btn btn-primary" runat="server" Text="Elegir premio" />
            <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" CssClass="btn btn-primary" />
            <asp:Button ID="btnCanjear" OnClick="btnCanjear_Click" Visible="false" runat="server" Text="Canjear" CssClass="btn btn-primary" />
        </div>
        <div class="col-sm"></div>
    </div>

    <!--Seccion oculta canje exitoso premio-->
    <div class="row" id="divCanjeExitoso" visible="false" runat="server">
        <div class="col-sm"></div>
        <div class="col-sm d-flex flex-column align-items-center">
            <asp:Label CssClass="h2" ID="lblCanjeExitoso" runat="server" Text="Artículo canjeado exitosamente!"></asp:Label>
            <asp:Button ID="btnInicio" runat="server" OnClick="btnInicio_Click" Text="Ir al inicio" CssClass="btn btn-primary" />
        </div>
        <div class="col-sm"></div>
    </div>
</asp:Content>
