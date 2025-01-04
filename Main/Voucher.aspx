<%@ Page Title="Canje" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Voucher.aspx.cs" Inherits="Main.Voucher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 style="justify-self:center" id="title"><%: Title %></h3>
    <hr />
    <div class="row">
        <div class="col-sm"></div>
        <div class="col-sm">
            <h6>Ingrese su Número de documento:</h6>
            <br />
            <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
            <asp:Button ID="btnAceptarDNI" OnClick="btnAceptarDNI_Click" runat="server" Text="Aceptar" />
        </div>
        <div class="col-sm"></div>
    </div>
</asp:Content>
