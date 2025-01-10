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
                if (Session["cliente"] != null && Session["codigo"] != null && Session["articulo"] != null)
                {
                    Response.Redirect("Canjear.aspx"); //valida si viene desde la pagina canje
                }
                else
                {
                    cargarDatos();
                    VoucherDB voucherDB = new VoucherDB();
                    List<Voucher> list = voucherDB.listarCanjes(cliente.Id);
                    if (list.Count != 0)
                    {
                        //valida si hay canjes y llena la tabla de lo contrario no la muestra
                        gwCanjes.DataSource = list;
                        gwCanjes.DataBind();
                        lblNoCanjes.Visible = false;
                    }
                }
            }
        }
        public void cargarDatos()
        {
            //Llena los campos con los datos del usuario
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
