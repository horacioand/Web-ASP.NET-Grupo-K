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
                art1img1.ImageUrl = listA[0].listImagenes[0];
                art1img2.ImageUrl = listA[0].listImagenes[1];
                art1img3.ImageUrl = listA[0].listImagenes[2];
                lblMarca1.Text = listA[0].Marca.Nombre;
                lblPrecio1.Text += listA[0].Precio.ToString();
                descripcion1.Text = listA[0].Descripcion;
                articulo2.Text = listA[1].Nombre;
                art2img1.ImageUrl = listA[1].listImagenes[0];
                art2img2.ImageUrl = listA[1].listImagenes[1];
                art2img3.ImageUrl = listA[1].listImagenes[2];
                lblMarca2.Text = listA[1].Marca.Nombre;
                lblPrecio2.Text += listA[1].Precio.ToString();
                descripcion2.Text = listA[1].Descripcion;
                articulo3.Text = listA[2].Nombre;
                art3img1.ImageUrl = listA[2].listImagenes[0];
                art3img2.ImageUrl = listA[2].listImagenes[1];
                art3img3.ImageUrl = listA[2].listImagenes[2];
                lblMarca3.Text = listA[2].Marca.Nombre;
                lblPrecio3.Text += listA[2].Precio.ToString();
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