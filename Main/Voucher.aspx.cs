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
            //cargarCliente();
        }

        protected void btnAceptarDNI_Click(object sender, EventArgs e)
        {
            string nroDocumento = txtDni.Text;

            
        }

        //Solo para testear que funcione bien la clase negocio del cliente
        //
        //public void cargarCliente()
        //{
        //    ClienteDB clienteDB = new ClienteDB();
        //    List<Cliente> listC = new List<Cliente>();
        //    listC = clienteDB.listarCliente();
        //}
    }
}