using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using System.Timers;
namespace Main
{
    public partial class Canjear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
            //
            //temporal para ver si trae session
            if (Session["cliente"] == null)
            {
                Response.Write("No se encontró el cliente en la sesión.");
            }
            else
            {
                Cliente cliente = (Cliente)Session["cliente"];
                Response.Write("cliente encontrado: " + cliente.Id);
            }
            //
            //temporal para ver si trae session
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
            //temporal para ver si trae session
            if (Session["articulo"] == null)
            {
                Response.Write("No se encontró el articulo en la sesión.");
            }
            else
            {
                int articulo = (int)Session["articulo"];
                Response.Write("Código encontrado: " + articulo);
            }
            //
            //
            //

            if (Session["codigo"] != null)
            {
                if (Session["articulo"] == null)
                {
                    tbCodigo.Enabled = false;
                    tbCodigo.Text = (string)Session["codigo"];
                    lblInfo.Text = "Codigo ingresado:";
                    btnAceptar.Text = "Cancelar";
                    btnAceptar.BackColor = System.Drawing.Color.Red;
                    btnAceptar.BorderColor = System.Drawing.Color.Red;
                    Response.Redirect("Premios.aspx");
                }
                else
                {
                    if (Session["cliente"] == null)
                    {
                        Response.Redirect("Cliente.aspx");
                    }
                    else
                    {
                        rowDivCanjear.Visible = true;
                        artSeleccionado.Text = "Articulo seleccionado: " + Session["articuloNombre"];
                        rowDivCodigo.Visible = false;
                    }
                }
            }
        }
        public void canjearArticulo()
        {
            VoucherDB voucherDB = new VoucherDB();
            Cliente cliente = (Cliente)Session["cliente"];
            int articulo = (int)Session["articulo"];
            string codigo = (string)Session["codigo"];
            voucherDB.canjear(cliente.Id, articulo, codigo);
        }
        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            canjearArticulo();
            Session["articulo"] = null;
            Session["codigo"] = null;
            rowDivCanjear.Visible = false;
            rowDivCodigo.Visible = false;
            divCanjeExitoso.Visible = true;
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["codigo"] != null)
                {
                    Session["codigo"] = null;
                    Response.Redirect("Canjear.aspx");
                }
                if (tbCodigo.Text != "")
                {
                    VoucherDB voucherDB = new VoucherDB();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    //valida si el voucher existe o ya ha sido canjeado
                    if (voucherDB.Validar(tbCodigo.Text))
                    {
                        string codigo = tbCodigo.Text;
                        Session["codigo"] = codigo;
                        //valida si ya se inicio sesion

                    }
                    else
                    {
                        lblError.Text = "Codigo incorrecto o ya canjeado";
                        rowDivCodigo.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }


        protected void btn1_Click(object sender, EventArgs e)
        {
            Session["articulo"] = 1;
            Session["codigo"] = tbCodigo.Text;
            Response.Redirect("Premios.aspx");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Session["articulo"] = 2;
            Session["codigo"] = tbCodigo.Text;
            Response.Redirect("Premios.aspx");
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            Session["articulo"] = 3;
            Session["codigo"] = tbCodigo.Text;
            Response.Redirect("Premios.aspx");
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            Response.Redirect("Perfil.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Session["codigo"] = null;
            Session["articulo"] = null;
            Response.Redirect("Canjear.aspx");
        }

        protected void btnCambiarArticulo_Click(object sender, EventArgs e)
        {
            Session["articulo"] = null;
            Response.Redirect("Premios.aspx");
        }
    }
}