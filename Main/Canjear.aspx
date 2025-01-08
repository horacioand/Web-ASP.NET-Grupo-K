<%@ Page Title="Canje" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Canjear.aspx.cs" Inherits="Main.Canjear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 style="justify-self: center" id="title"><%: Title %></h3>
    <hr />
    <div class="row" id="rowTxtCodigo" runat="server">
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

    <!--Seccion oculta elegir premio-->
    <div class="row" id="rowTitleCanje" visible="false" runat="server">
        <div class="d-flex justify-content-center"><label class="h2">Elija su premio:</label></div>
    </div>
    <div class="row" id="rowElegirPremio" visible="false" runat="server">
        <div id="Premio1" class="col-md-4 articulo d-flex flex-column align-items-center" aria-labelledby="">
            <asp:Label ID="articulo1" CssClass="h5" runat="server" Text=""></asp:Label>
            <asp:Image ID="img1" runat="server" />
            <asp:Label ID="descripcion1" runat="server" Text=""></asp:Label>
            <asp:Button ID="btn1" CssClass="btn btn-primary" runat="server" Text="Elegir" OnClick="btn1_Click" />
        </div>
        <div id="Premio2" class="col-md-4 articulo d-flex flex-column align-items-center" aria-labelledby="">
            <asp:Label ID="articulo2" CssClass="h5" runat="server" Text=""></asp:Label>
            <asp:Image ID="img2" runat="server" />
            <asp:Label ID="descripcion2" runat="server" Text=""></asp:Label>
            <asp:Button ID="btn2" CssClass="btn btn-primary" runat="server" Text="Elegir" OnClick="btn2_Click" />
        </div>
        <div id="Premio3" class="col-md-4 articulo d-flex flex-column align-items-center" aria-labelledby="">
            <asp:Label ID="articulo3" CssClass="h5" runat="server" Text=""></asp:Label>
            <asp:Image ID="img3" runat="server" />
            <asp:Label ID="descripcion3" runat="server" Text=""></asp:Label>
            <asp:Button ID="btn3" CssClass="btn btn-primary" runat="server" Text="Elegir" OnClick="btn3_Click" />
        </div>
    </div>
</asp:Content>
