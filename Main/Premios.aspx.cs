using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Main
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarArticulos();
            if (Session["codigo"] != null)
            {
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
                rowDivCancelar.Visible = true;
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
            Session["articulo"] = 1;
            Session["articuloNombre"] = articulo1.Text;
            Response.Redirect("Canjear.aspx");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            Session["articulo"] = 2;
            Session["articuloNombre"] = articulo2.Text;
            Response.Redirect("Canjear.aspx");
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            Session["articulo"] = 3;
            Session["articuloNombre"] = articulo3.Text;
            Response.Redirect("Canjear.aspx");
        }
        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Canjear.aspx");
        }
    }
}