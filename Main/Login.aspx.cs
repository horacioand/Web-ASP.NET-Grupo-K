using Dominio;
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
            cliente.Id = -1;
            Session.Add("cliente", cliente);
            Response.Redirect("Perfil.aspx");
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEmail.Text != "")
                {
                    ClienteDB clienteDB = new ClienteDB();
                    cliente = clienteDB.traerCliente(tbEmail.Text);
                    if (cliente.Id == 0 )
                    {
                        lblError.Text = "Email incorrecto o no registrado";
                        lblError.ForeColor = System.Drawing.Color.Red;
                    }else
                    {
                        //se inicia sesion redirigiendo a la pagina perfil
                        Session.Add("cliente", cliente);
                        Response.Redirect("Perfil.aspx");
                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
    }
}