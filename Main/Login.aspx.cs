using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Main
{
    public partial class Login : Page
    {
        Cliente cliente = new Cliente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            divRowRegistro.Visible = true;
            divRowLogin.Visible = false;
            divRowBtnRegistro.Visible = false;
            divRowVolverInicio.Visible = true;
        }
        protected void btnVolverIinicio_Click(object sender, EventArgs e)
        {
            divRowRegistro.Visible = false;
            divRowVolverInicio.Visible = false;
            divRowBtnRegistro.Visible = true;
            divRowLogin.Visible = true;
        }
        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbEmail.Text != "")
                {
                    ClienteDB clienteDB = new ClienteDB();
                    cliente = clienteDB.traerCliente(tbEmail.Text);
                    if (cliente.Id == 0 )
                    {
                        lblError.Text = "Email incorrecto o no registrado";
                        lblError.ForeColor = System.Drawing.Color.Red;
                    }else
                    {
                        //se inicia sesion redirigiendo a la pagina perfil
                        Session.Add("cliente", cliente);
                        Response.Redirect("Perfil.aspx");
                    }
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex.ToString());
            }
        }

        protected void btnConfirmarRegistro_Click(object sender, EventArgs e)
        {
            //Falta manejo de excepciones pero ya funciona la carga del cliente a la db (con los campos correctos)
            //Falta validar campos vacios, mail y numeros
            string documento = tbDocumentoRegistro.Text;
            string nombre = tbNombreRegistro.Text;
            string apellido = tbApellidoRegistro.Text;
            string email = tbEmailRegistro.Text;
            string direccion = tbDireccionRegistro.Text;
            string ciudad = tbCiudadRegistro.Text;
            int cp = int.Parse(tbCodigoPostalRegistro.Text);
           

            //Esto lo podemos limpiar haciendo un constructor que pase todo por parametros
            Cliente nuevoCliente = new Cliente();
            nuevoCliente.Documento = documento;
            nuevoCliente.Nombre = nombre;
            nuevoCliente.Apellido = apellido;
            nuevoCliente.Email = email;
            nuevoCliente.Direccion = direccion;
            nuevoCliente.Ciudad = ciudad;
            nuevoCliente.Cp = cp;
            ClienteDB clienteDB = new ClienteDB();
            clienteDB.crearCliente(nuevoCliente);

            //Falta que lleve con la session del cliente activa
            Response.Redirect("Perfil.aspx");
        }
    }
}