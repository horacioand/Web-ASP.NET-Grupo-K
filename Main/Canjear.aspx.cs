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
            if ((IsPostBack)) //si no es la primera vez que carga la pagina
            {
                Session["codigo"] = null;
                Session["articulo"] = null;
            }
            if (Session["codigo"] != null)
            {
                rowTxtCodigo.Visible = false;
                rowTitleCanje.Visible = true;
                rowElegirPremio.Visible = true;
                CargarArticulos();
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
                        CargarArticulos();
                        rowTxtCodigo.Visible = false;
                        rowTitleCanje.Visible = true;
                        rowElegirPremio.Visible = true;
                    }
                    else
                    {
                        lblError.Text = "Codigo incorrecto o ya canjeado";
                        rowTxtCodigo.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }
        public void CargarArticulos()
        {
            ArticuloDB db = new ArticuloDB();
            List<Articulo> listA = new List<Articulo>();
            try
            {
                listA = db.ListarArticulos();
                articulo1.Text = listA[0].Nombre;
                img1.ImageUrl = listA[0].listImagenes[0];
                descripcion1.Text = listA[0].Descripcion;
                articulo2.Text = listA[1].Nombre;
                img2.ImageUrl = listA[1].listImagenes[0];
                descripcion2.Text = listA[1].Descripcion;
                articulo3.Text = listA[2].Nombre;
                img3.ImageUrl = listA[2].listImagenes[0];
                descripcion3.Text = listA[2].Descripcion;
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Session["Articulo"] = 1;
            Session["codigo"] = tbCodigo.Text; //lo asigno aca porque si no no me lo pasa a la siguiente pagina
            Response.Redirect("Perfil.aspx");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Session["Articulo"] = 2;
            Session["codigo"] = tbCodigo.Text;
            Response.Redirect("Login.aspx");
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            Session["Articulo"] = 3;
            Session["codigo"] = tbCodigo.Text;
            Response.Redirect("Login.aspx");
        }
    }
}