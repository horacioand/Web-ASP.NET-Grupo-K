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

            //temporal para ver si trae el codigo
            if (Session["codigo"] == null)
            {
                Response.Write("No se encontró el código en la sesión.");
            }
            else
            {
                string codigo = (string)Session["codigo"];
                Response.Write("Código encontrado: " + codigo);
            }
            //

            if (Session["cliente"] == null) //redirige al login
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                cliente = (Cliente)Session["cliente"]; //trae el cliente de la sesion
                if (cliente.Id == -1)
                {
                    cliente.Id = 0;
                    Session["cliente"] = null; //en caso de que no se haga el registro se reinicia el login
                    btnCerrarSesion.Text = "Cancelar";
                }
                else
                {
                    if (Session["cliente"] != null && Session["codigo"] != null && Session["articulo"] != null)
                    {
                        Response.Redirect("Canjear.aspx");
                    }
                    else
                    {
                        cargarDatos();
                        VoucherDB voucherDB = new VoucherDB();
                        if (Session["codigo"] != null)
                        {
                            string codigo = (string)Session["codigo"];
                            if (voucherDB.Validar(codigo))
                            {
                                Session["codigo"] = codigo;
                            }
                            else
                            {
                                Response.Redirect("Perfil.aspx");
                            }
                        }
                        List<Voucher> list = voucherDB.listarCanjes(cliente.Id);
                        if (list.Count != 0)
                        {
                            gwCanjes.DataSource = list;
                            gwCanjes.DataBind();
                            lblNoCanjes.Visible = false;
                        }
                    }
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
