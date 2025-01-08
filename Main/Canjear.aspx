<%@ Page Title="Canje" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canjear.aspx.cs" Inherits="Main.Canjear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 style="justify-self:center" id="title"><%: Title %></h3>
    <hr />
    <div class="row">
        <div class="col-sm"></div>
        <div class="col-sm d-flex flex-column align-items-center">
            <asp:Label cssclass="h6" ID="lblInfo" runat="server" Text="Ingrese el codigo:"></asp:Label>
            <br />
            <asp:TextBox ID="tbCodigo" CssClass="form-control mb-2" runat="server"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" cssclass="" Text=""></asp:Label>
            <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" CssClass="btn btn-primary"/>
        </div>
        <div class="col-sm"></div>
    </div>
</asp:Content>
