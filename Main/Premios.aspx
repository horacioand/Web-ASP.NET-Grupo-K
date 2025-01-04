<%@ Page Title="Premios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="Main.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
       <h3 style="justify-self:center" id="title"><%: Title %></h3>
        <hr />
        <div class="row">
    <section class="col-md-4" aria-labelledby="">
        <h4 id="articulo-1">Mochila porta notebook</h4>
        <!-- La imagen viene desde db -->
        <asp:Image ID="Image1" runat="server" />    
        <p>
            Descrippcciioonn
        </p>
    </section>
    <section class="col-md-4" aria-labelledby="">
        <h4 id="articulo-2">Mouse HeroG502</h4>
        <!-- La imagen viene desde db -->
        <asp:Image ID="Image2" runat="server" />
        <p>
            Descripcciioonn
        </p>
    </section>
    <section class="col-md-4" aria-labelledby="">
        <h4 id="articulo-3">Teclado Rk M75</h4>
        <!-- La imagen viene desde db -->
        <asp:Image ID="Image3" runat="server" />
        <p>
            Descr..
        </p
    </section>
</div>
    </main>
</asp:Content>
