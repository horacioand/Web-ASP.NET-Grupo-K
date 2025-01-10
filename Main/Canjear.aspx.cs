using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Timers;
using Microsoft.Ajax.Utilities;
namespace Main
{
    public partial class Canjear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["codigo"] != null)
            {
                //valida si ya se ha ingresado un codigo
                codigoAceptado();
                premioSeleccionado();
            }
        }
        public void codigoAceptado()
        {
            tbCodigo.Enabled = false;
            tbCodigo.Text = (string)Session["codigo"];
            lblInfo.Text = "Codigo ingresado:";
            btnAceptar.Text = "Cancelar";
            btnAceptar.BackColor = System.Drawing.Color.Red;
            btnAceptar.BorderColor = System.Drawing.Color.Red;
            btnPremio.Visible = true;
            lblError.Visible = false;
        }
        public void premioSeleccionado()
        {
            if (Session["articulo"] != null)
            {
                btnPremio.Text = "Cambiar premio";
                int articulo = (int)Session["articulo"];
                switch (articulo)
                {
                    //al ser solo 3 premios lo podemos manejar por un switch
                    case 1:
                        lblArticulo.Text = "Premio seleccionado: Mochila Porta Notebook";
                        break;
                    case 2:
                        lblArticulo.Text = "Premio seleccionado: Mouse Gamer Hero G502";
                        break;
                    default:
                        lblArticulo.Text = "Premio seleccionado: Teclado Mecánico 75% Rk M75";
                        break;
                }
                lblConfirmar.Visible = true;
                btnCanjear.Visible = true;

            }
        }
        public void canjearArticulo()
        {
            //canjea el codigo en la db
            VoucherDB voucherDB = new VoucherDB();
            Cliente cliente = (Cliente)Session["cliente"];
            int articulo = (int)Session["articulo"];
            string codigo = (string)Session["codigo"];
            voucherDB.canjear(cliente.Id, articulo, codigo);
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["codigo"] != null)
                {
                    //cancela el canje y recarga la pagina
                    Session["codigo"] = null;
                    Session["articulo"] = null;
                    Response.Redirect("Canjear.aspx");
                }
                else
                {
                    lblError.ForeColor = System.Drawing.Color.Red;
                    if (!tbCodigo.Text.IsNullOrWhiteSpace()) //valida que el campo no este vacio
                    {
                        VoucherDB voucherDB = new VoucherDB();
                        //valida si el voucher existe o ya ha sido canjeado
                        if (voucherDB.Validar(tbCodigo.Text))
                        {
                            Session["codigo"] = tbCodigo.Text;
                            codigoAceptado();
                        }
                        else
                        {
                            lblError.Text = "Codigo incorrecto o ya canjeado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
        protected void btnPremio_Click(object sender, EventArgs e)
        {
            premioSeleccionado();
            Response.Redirect("Premios.aspx");
        }
        protected void btnCanjear_Click(object sender, EventArgs e)
        {
            //llama al metodo canjear y reinicia los datos del canje en la session
            if (Session["cliente"] != null)
            {
                canjearArticulo();
                Session["articulo"] = null;
                Session["codigo"] = null;
                rowDivCodigo.Visible = false;
                divCanjeExitoso.Visible = true;
            }else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}