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
    public partial class Contact : Page
    {
        Cliente cliente = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEmail.Text != "")
                {
                    ClienteDB clienteDB = new ClienteDB();
                    cliente = clienteDB.traerCliente(tbEmail.Text);

                }
                else
                {
                    lblError.Text = "Email incorrecto o no registrado";
                    lblError.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}