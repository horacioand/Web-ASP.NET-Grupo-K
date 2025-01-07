using Dominio;
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
            if (!IsPostBack)
            {
                if (cliente.Id == 0)
                {
                    string id = Request.QueryString["clienteId"];
                    if (id != null)
                    {
                        cliente.Id = int.Parse(Request.QueryString["clienteId"]);
                        Session["clienteId"] = cliente.Id;
                    }
                    else if (Session["clienteId"] == null) 
                    {
                        Response.Redirect("Login.aspx");
                    }else
                    {
                        cliente.Id = (int)Session["clienteId"];
                    }
                }
            }
        }
    }
}