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

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCodigo.Text != "")
                {
                    VoucherDB voucherDB = new VoucherDB();
                    //valida si el voucher existe o ya ha sido canjeado
                    if (voucherDB.Validar(tbCodigo.Text))
                    {
                        string codigo = tbCodigo.Text;
                        Session.Add("codigo", codigo);
                        if (Session["clienteId"] == null)
                        {
                            Response.Redirect("Login.aspx");
                        }
                        //continuar con el canje
                    }else
                    {
                        lblError.Text = "Codigo incorrecto o ya canjeado";
                        lblError.ForeColor = System.Drawing.Color.Red;
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