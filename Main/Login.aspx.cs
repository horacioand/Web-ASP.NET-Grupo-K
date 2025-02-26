﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Main
{
    public partial class Login : Page
    {
        Cliente cliente = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            divRowRegistro.Visible = true;
            divRowLogin.Visible = false;
            divRowBtnRegistro.Visible = false;
            divRowVolverInicio.Visible = true;
        }
        protected void btnVolverIinicio_Click(object sender, EventArgs e)
        {
            divRowRegistro.Visible = false;
            divRowVolverInicio.Visible = false;
            divRowBtnRegistro.Visible = true;
            divRowLogin.Visible = true;
        }
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEmail.Text != "")
                {
                    ClienteDB clienteDB = new ClienteDB();
                    cliente = clienteDB.traerCliente(tbEmail.Text);
                    if (cliente.Id == 0)
                    {
                        lblError.Text = "Email incorrecto o no registrado";
                        lblError.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        //se inicia sesion redirigiendo a la pagina perfil
                        Session.Add("cliente", cliente);
                        if (Session["codigo"] != null)
                        {
                            Response.Redirect("Canjear.aspx");
                        }
                        else
                        {
                            Response.Redirect("Perfil.aspx");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }

        protected void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbNombreRegistro.Text) || string.IsNullOrEmpty(tbApellidoRegistro.Text) || string.IsNullOrEmpty(tbDocumentoRegistro.Text) || string.IsNullOrEmpty(tbEmailRegistro.Text) || string.IsNullOrEmpty(tbDireccionRegistro.Text) || string.IsNullOrEmpty(tbCiudadRegistro.Text) || string.IsNullOrEmpty(tbCodigoPostalRegistro.Text))
                {
                    lblRegistroError.Text = "Debe llenar todos los campos";
                    return;
                }
                ClienteDB clienteDB = new ClienteDB();
                if (clienteDB.validarDatos(tbDocumentoRegistro.Text, 0))
                {
                    lblRegistroError.Text = "Documento ya registrado";
                    return;
                }
                if (clienteDB.validarDatos(tbEmailRegistro.Text, 1))
                {
                    lblRegistroError.Text = "Email ya registrado";
                    return;
                }
                if (!tbEmailRegistro.Text.Contains("@") || !tbEmailRegistro.Text.Contains(".com"))
                {
                    lblRegistroError.Text = "Ingrese un email valido";
                    return;
                }
                cliente.Documento = tbDocumentoRegistro.Text;
                cliente.Email = tbEmailRegistro.Text;
                cliente.Cp = int.Parse(tbCodigoPostalRegistro.Text);
                cliente.Direccion = tbDireccionRegistro.Text;
                cliente.Ciudad = tbCiudadRegistro.Text;
                cliente.Nombre = tbNombreRegistro.Text;
                cliente.Apellido = tbApellidoRegistro.Text;

                EmailService emailService = new EmailService();
                string destinatario = tbEmailRegistro.Text;
                string asunto = "Registro exitoso";
                string cuerpo = "Bienvenido a la pagina de web asp, su registro ha sido exitoso";
                emailService.armarCorreo(destinatario,asunto,cuerpo);
                emailService.enviarCorreo();

                clienteDB.crearCliente(cliente); // crea el cliente si todos los datos son correctos
                cliente = clienteDB.traerCliente(tbEmailRegistro.Text); // trae al cliente creado pero ahora con el id ya asignado
                Session.Add("cliente", cliente);

                if (Session["codigo"] != null)
                {
                    Response.Redirect("Canjear.aspx");
                }else
                {
                    Response.Redirect("Perfil.aspx");
                }
            }
            catch (Exception ex)
            {
                lblRegistroError.Text = "Uno o varios campos son invalidos";
                Session.Add("error", ex);
            }
        }
    }
}