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
    public partial class Voucher : System.Web.UI.Page
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
                    if (voucherDB.Validar(tbCodigo.Text))
                    {
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