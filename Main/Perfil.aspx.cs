using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Main
{
    public partial class Perfil : System.Web.UI.Page
    {
        Cliente cliente = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cliente"] == null) //redirige al login
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                cliente = (Cliente)Session["cliente"]; //trae el cliente de la sesion
            }
        }
    }
}
