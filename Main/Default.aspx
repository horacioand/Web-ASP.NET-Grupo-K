<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Main._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Bienvenido!</h1>
            <p class="lead">Bienvenido a la web del comercio............</p>
            <p><a href="Default.aspx" class="btn btn-primary btn-md">Inicio</a></p>
        </section>
        <!-- Dejo el default como la página de inicio del comercio, despues le podemos agregar una descripción ficticia -->
        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Sobre nosotros</h2>
                <p>
                    Somos un comercio de ejemplo para una web de canje de productos...
                </p>

            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Nuestros productos</h2>
                <p>
                    Próximamente...
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Tienes un cupón?</h2>
                <p>
                    Estamos realizando un sorteo entre todos nuestros clientes, si tienes un cupón puedes canjearlo <a href="Canjear.aspx">aquí</a>
                </p>

            </section>
        </div>
    </main>

</asp:Content>
