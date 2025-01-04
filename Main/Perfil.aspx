<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Main.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">       
            <div class="articulo" >
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                <asp:Label ID="lblDocumento" runat="server" Text="Documento"></asp:Label>
                <asp:TextBox ID="tbDocumento" runat="server"></asp:TextBox>
                <asp:Button CssClass="btn btn-primary" ID="btnIniciarSesion" OnClick="btnIniciarSesion_Click" runat="server" Text="Iniciar sesion" />
            </div>
            <div class="articulo" >
                <asp:Label ID="lblRegistrase" runat="server" Text="Si aun no te has registrado"></asp:Label>
                <asp:Button CssClass="btn btn-primary" ID="btnRegistrarse" OnClick="btnRegistrarse_Click" runat="server" Text="Registrarse" />
            </div>
    </main>
</asp:Content>
