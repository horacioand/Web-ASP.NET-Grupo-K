<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Main.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="row" id="divRowLogin" runat="server">
            <div class="col-4"></div>
            <div class="col-4 d-flex flex-column align-items-center">
                <div class="mb-1">
                    <label for="tbEmail" class="form-label">Email</label>
                    <asp:TextBox ID="tbEmail" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-1">
                    <asp:Label ID="lblError" runat="server" CssClass="" Text=""></asp:Label>
                </div>
                <div class="d-flex mb-1 justify-content-center">
                    <asp:Button CssClass="btn btn-primary" ID="btnIniciarSesion" OnClick="btnIniciarSesion_Click" runat="server" Text="Ingresar" />
                </div>
            </div>
            <div class="col-4"></div>
        </div>
        <hr />
        <div class="row" id="divRowBtnRegistro" runat="server">
            <div class="col-4"></div>
            <div class="col-4 d-flex flex-column align-items-center">
                <asp:Label CssClass="mx-auto mb-2" ID="lblRegistrase" runat="server" Text="Si aun no te has registrado"></asp:Label>
                <asp:Button CssClass="btn btn-primary" ID="btnRegistrarse" OnClick="btnRegistrarse_Click" runat="server" Text="Registrarse" />
            </div>
            <div class="col-4"></div>
        </div>
        <div class="row" id="divRowVolverInicio" runat="server" visible="false">
            <div class="col-4"></div>
            <div class="col-4 d-flex flex-column align-items-center">
                <asp:Label CssClass="mx-auto mb-1" ID="lblVolverInicio" runat="server" Text="Ya tienes una cuenta?"></asp:Label>
                <asp:Button CssClass="btn btn-primary" ID="btnVolverIinicio" OnClick="btnVolverIinicio_Click" runat="server" Text="Iniciar Sesion" />
            </div>
            <div class="col-4"></div>
        </div>
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4 d-flex flex-column align-items-center" runat="server" id="divRowRegistro" visible="false">
                <div class="mb-2">
                    <asp:Label ID="lblDocumento" cssclass="form-label" runat="server" Text="DNI:"></asp:Label>
                    <asp:TextBox ID="tbDocumentoRegistro" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">
                    <asp:Label ID="lblNombre" CssClass="form-label" runat="server" Text="Nombre:"></asp:Label>
                    <asp:TextBox ID="tbNombreRegistro" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">
                    <asp:Label ID="lblApellido" cssclass="form-label" runat="server" Text="Apellido:"></asp:Label>
                    <asp:TextBox ID="tbApellidoRegistro" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">
                    <asp:Label ID="lblEmail" runat="server" CssClass="form-label" Text="Email:"></asp:Label>
                    <asp:TextBox ID="tbEmailRegistro" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">
                    <asp:Label ID="lblDireccion" cssclass="form-label" runat="server" Text="Direccion:"></asp:Label>
                    <asp:TextBox ID="tbDireccionRegistro" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">
                    <asp:Label ID="lblCiudad" cssclass="form-label" runat="server" Text="Ciudad:"></asp:Label>
                    <asp:TextBox ID="tbCiudadRegistro" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">
                    <asp:Label ID="lblCodigoPostal" CssClass="form-label" runat="server" Text="Codigo Postal:"></asp:Label>
                    <asp:TextBox ID="tbCodigoPostalRegistro" runat="server" class="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">   
                    <asp:Label ID="lblRegistroError" ForeColor="Red" cssclass="form-label" runat="server" Text=""></asp:Label>
                </div>
                <div class="">
                    <asp:Button CssClass="btn btn-primary" ID="btnConfirmarRegistro" runat="server" text="Registrarse" OnClick="btnConfirmarRegistro_Click"/>
                </div>
            </div>
            <div class="col-4"></div>
        </div>
    </main>
</asp:Content>
