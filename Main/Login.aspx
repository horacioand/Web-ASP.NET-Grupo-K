<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Main.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4 d-flex flex-column align-items-center">
                <div class="mb-3">
                    <label for="tbEmail" class="form-label">Email</label>
                    <asp:TextBox ID="tbEmail" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblError" runat="server" CssClass="" Text=""></asp:Label>
                </div>
                <div class="d-flex mb-1 justify-content-center">
                    <asp:Button CssClass="btn btn-primary" ID="btnIniciarSesion" OnClick="btnIniciarSesion_Click" runat="server" Text="Ingresar" />
                </div>
            </div>
            <div class="col-4"></div>
        </div>
        <hr />
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4 d-flex mb-2">
                <asp:Label CssClass="mx-auto" ID="lblRegistrase" runat="server" Text="Si aun no te has registrado"></asp:Label>
            </div>
            <div class="col-4"></div>
        </div>
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4">
                <div class="d-flex mb-3 justify-content-center">
                    <asp:Button CssClass="btn btn-primary" ID="btnRegistrarse" OnClick="btnRegistrarse_Click" runat="server" Text="Registrarse" />
                </div>
            </div>
            <div class="col-4"></div>
        </div>
    </main>
</asp:Content>
