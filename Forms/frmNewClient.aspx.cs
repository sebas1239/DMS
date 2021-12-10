using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS.Forms
{
    public partial class frmNewClient : System.Web.UI.Page
    {

        #region Variables

        AD.dstCliente.tbClienteRow dr_Cliente;
        AD.clsCliente m_clscliente = new AD.clsCliente();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            tipo.Items.Add("Natural");
            tipo.Items.Add("Juridica");

            Pais.Items.Add("Alemania");
            Pais.Items.Add("Argentina");
            Pais.Items.Add("Brasil");
            Pais.Items.Add("Canadá");
            Pais.Items.Add("Chile");
            Pais.Items.Add("Colombia");
            Pais.Items.Add("Hungría");
            Pais.Items.Add("Perú");

            Linea.Items.Add("Auxiliares");
            Linea.Items.Add("Cuero");
            Linea.Items.Add("Tintas");
            Linea.Items.Add("Papel");
            Linea.Items.Add("Pintura");
            Linea.Items.Add("Resinas");

            Area.Items.Add("Empresa");
            Area.Items.Add("Hogar");
            Area.Items.Add("Venta");
        }

        protected void CreateClient_Click(object sender, EventArgs e)
        {
            Session["Tipo"] = tipo.Text;
            Session["NombreCliente"] = Nombre.Text;
            Session["Documento"] = Documento.Text;
            Session["TelefonoCliente"] = Telefono.Text;
            Session["Pais"] = Pais.Text;
            Session["Linea"] = Linea.Text;
            Session["Area"] = Area.Text;
            Session["CodigoPostal"] = CodigoPostal.Text;
            Session["DireccionCliente"] = Direccion.Text;

            if (Encuesta.Checked)
            {
                Session["Encuesta"] = "1";
            }
            else Session["Encuesta"] = "0";

            Session["Firma"] = Firma.Text;
            Session["EmailCliente"] = Email.Text;

            dr_Cliente = m_clscliente.tbCliente.NewtbClienteRow();

            dr_Cliente.Tipo = Session["Tipo"].ToString();
            dr_Cliente.Nombre = Session["NombreCliente"].ToString();
            dr_Cliente.Documento = Session["Documento"].ToString();
            dr_Cliente.telefono = Session["TelefonoCliente"].ToString();
            dr_Cliente.Pais = Session["Pais"].ToString();
            dr_Cliente.Linea = Session["Linea"].ToString();
            dr_Cliente.Area = Session["Area"].ToString();
            dr_Cliente.CodigoPostal = Session["CodigoPostal"].ToString();
            dr_Cliente.Direccion = Session["DireccionCliente"].ToString();
            dr_Cliente.Encuesta = Session["Encuesta"].ToString();
            dr_Cliente.Firma = Session["Firma"].ToString();
            dr_Cliente.UserName = Session["Email"].ToString();
            dr_Cliente.EmailCliente = Session["EmailCliente"].ToString();

            m_clscliente.GuardarCliente(dr_Cliente );
            EnviarCorreo();
            Server.Transfer("frmCliente.aspx", true);

            


        }

        public void EnviarCorreo ()
        {
            AD.clsReglasNegocio oRN = new AD.clsReglasNegocio();
            string strMensaje = @"El Cliente  " + Session["NombreCliente"].ToString() + " fue creado en nuestra base de datos con la siguiente información:" + Environment.NewLine +
              "Nombre o Razón Social:" + Session["NombreCliente"].ToString() + Environment.NewLine +
              "Cedula o Nit:" + Session["Documento"].ToString() + Environment.NewLine +
              "Telefon : "+ Session["TelefonoCliente"].ToString()+ Environment.NewLine +
              "Pais: "+ Session["Pais"].ToString() + Environment.NewLine +
              "Linea: " + Session["Linea"].ToString() + Environment.NewLine +
              "Area: " + Session["Area"].ToString() + Environment.NewLine +
              "CodigoPostal : " + Session["CodigoPostal"].ToString() + Environment.NewLine +
              "Direccion : " + Session["DireccionCliente"].ToString() + Environment.NewLine +
              "Encuesta : " + Session["Encuesta"].ToString() + Environment.NewLine +
              "Firma: " + Session["Firma"].ToString() + Environment.NewLine ;

           oRN.EnviarCorreo(Session["EmailCliente"].ToString(), "Nuevo Cliente " + Session["NombreCliente"].ToString() , strMensaje);
            

           
        }
    }
}