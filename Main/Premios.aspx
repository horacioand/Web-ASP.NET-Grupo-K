<%@ Page Title="Premios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="Main.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h3 style="justify-self: center" id="title"><%: Title %></h3>
        <hr />
        <div class="row" id="rowDivCancelar" visible="false" runat="server">
            <div class="col-sm"></div>
            <div class="col-sm d-flex flex-column align-items-center">
                <asp:Button ID="btnVolver" OnClick="btnVolver_Click" CssClass="btn btn-primary" runat="server" Text="Volver" />
            </div>
            <div class="col-sm"></div>
        </div>
        <div class="row">
            <div id="Premio1" class="articulo card" aria-labelledby="">
                <asp:Label ID="articulo1" CssClass="h4" runat="server" Text=""></asp:Label>
                <div class="carrusel">
                    <div class="slides">
                        <asp:Image alt="Imagen 1" ID="art1img1" runat="server"></asp:Image>
                        <asp:Image alt="Imagen 2" ID="art1img2" runat="server"></asp:Image>
                        <asp:Image alt="Imagen 3" ID="art1img3" runat="server"></asp:Image>
                    </div>
                </div>
                <asp:Label ID="descripcion1" cssclass="form-label" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblMarca1" cssclass="form-label" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblPrecio1" cssclass="form-label" runat="server" Text="Precio: "></asp:Label>
                <asp:Button ID="btn1" CssClass="btn btn-primary" Visible="false" runat="server" Text="Elegir" OnClick="btn1_Click" />
            </div>
            <div id="Premio2" class="articulo card" aria-labelledby="">
                <asp:Label ID="articulo2" CssClass="h4" runat="server" Text=""></asp:Label>
                <div class="carrusel">
                    <div class="slides">
                        <asp:Image alt="Imagen 1" ID="art2img1" runat="server"></asp:Image>
                        <asp:Image alt="Imagen 2" ID="art2img2" runat="server"></asp:Image>
                        <asp:Image alt="Imagen 3" ID="art2img3" runat="server"></asp:Image>
                    </div>
                </div>
                <asp:Label ID="descripcion2" cssclass="form-label" runat="server" Text=""></asp:Label>    
                <asp:Label ID="lblMarca2" cssclass="form-label" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblPrecio2" cssclass="form-label" runat="server" Text="Precio: "></asp:Label>
                <asp:Button ID="btn2" CssClass="btn btn-primary" Visible="false" runat="server" Text="Elegir" OnClick="btn2_Click" />
            </div>
            <div id="Premio3" class="articulo card" aria-labelledby="">
                <asp:Label ID="articulo3" CssClass="h4" runat="server" Text=""></asp:Label>
                <div class="carrusel">
                    <div class="slides">
                        <asp:Image alt="Imagen 1" ID="art3img1" runat="server"></asp:Image>
                        <asp:Image alt="Imagen 2" ID="art3img2" runat="server"></asp:Image>
                        <asp:Image alt="Imagen 3" ID="art3img3" runat="server"></asp:Image>
                    </div>
                </div>
                <asp:Label ID="descripcion3" cssclass="form-label" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblMarca3" cssclass="form-label" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblPrecio3" cssclass="form-label" runat="server" Text="Precio: "></asp:Label>
                <asp:Button ID="btn3" CssClass="btn btn-primary" Visible="false" runat="server" Text="Elegir" OnClick="btn3_Click" />
            </div>
        </div>
<!--Dejo este codigo css aca porque despues voy a intentar hacerlo con bootstrap-->
        <style>
            .carrusel {
                position: relative;
                width: 100%;
                overflow: hidden;
                max-width: 600px;
            }

            .slides {
                display: flex;
                animation: scroll 20s linear infinite;
            }

                .slides img {
                    width: 100%;
                    height: 500px;     
                    flex-shrink: 0;
                }

            @keyframes scroll {
                0% {
                    transform: translateX(0);
                }

                100% {
                    transform: translateX(-300%);
                }
            }
        </style>

    </main>
</asp:Content>
