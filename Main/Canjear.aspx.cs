using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace Main
{
    public partial class Canjear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["codigo"] != null)
            {
                if (Session["cliente"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    tbCodigo.Enabled = false;
                    tbCodigo.Text = (string)Session["codigo"];
                    lblInfo.Text = "Codigo ingresado:";
                    btnAceptar.Text = "Cancelar";
                    btnAceptar.BackColor = System.Drawing.Color.Red;
                    btnAceptar.BorderColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["codigo"] !=null)
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
                        Session.Add("codigo", codigo);
                        //valida si ya se inicio sesion
                        if (Session["cliente"] == null)
                        {
                            Response.Redirect("Login.aspx");
                        }else
                        {
                            Response.Redirect("Canjear.aspx");
                        }
                    }
                    else
                    {
                        lblError.Text = "Codigo incorrecto o ya canjeado";
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