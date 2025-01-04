﻿<%@ Page Title="Premios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="Main.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h3 style="justify-self: center" id="title"><%: Title %></h3>
        <hr />
        <div class="row">
            <div id="Premio1" class="col-md-4 articulo" aria-labelledby="">
                <asp:Label ID="articulo1" CssClass="h4" runat="server" Text=""></asp:Label>
                <asp:Image ID="img1" runat="server" />
                <asp:Label ID="descripcion1" runat="server" Text=""></asp:Label>
                <asp:Button ID="btn1" CssClass="btn btn-primary" runat="server" Text="Ver detalles" />
            </div>
            <div id="Premio2" class="col-md-4 articulo" aria-labelledby="">
                <asp:Label ID="articulo2" CssClass="h4" runat="server" Text=""></asp:Label>
                <asp:Image ID="img2" runat="server" />
                <asp:Label ID="descripcion2" runat="server" Text=""></asp:Label>
                <asp:Button ID="btn2" CssClass="btn btn-primary" runat="server" Text="Ver detalles" />
            </div>
            <div id="Premio3" class="col-md-4 articulo" aria-labelledby="">
                <asp:Label ID="articulo3" CssClass="h4" runat="server" Text=""></asp:Label>
                <asp:Image ID="img3" runat="server" />
                <asp:Label ID="descripcion3" runat="server" Text=""></asp:Label>
                <asp:Button ID="btn3" CssClass="btn btn-primary" runat="server" Text="Ver detalles" />
            </div>
        </div>
    </main>
</asp:Content>
