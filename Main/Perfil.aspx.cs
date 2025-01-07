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
                if (cliente.Id == -1 )
                {
                    cliente.Id = 0;
                    Session["cliente"] = null; //en caso de que no se haga el registro se reinicia el login
                    btnCerrarSesion.Text = "Cancelar";
                }else
                {
                    cargarDatos();
                    VoucherDB voucherDB = new VoucherDB();
                    gwCanjes.DataSource = voucherDB.listarCanjes(cliente.Id);
                    gwCanjes.DataBind();
                    
                }
            }
        }
        public void cargarDatos()
        {
            tbNombre.Text = cliente.Nombre;
            tbNombre.Enabled = false;
            tbApellido.Text = cliente.Apellido;
            tbApellido.Enabled = false;
            tbEmail.Text = cliente.Email;
            tbEmail.Enabled = false;
            tbDireccion.Text = cliente.Direccion;
            tbDireccion.Enabled = false;
            tbCiudad.Text = cliente.Ciudad;
            tbCiudad.Enabled = false;
            tbCP.Text = cliente.Cp.ToString();
            tbCP.Enabled = false;
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["cliente"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}
