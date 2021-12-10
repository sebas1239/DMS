using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace DMS
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            ///Usuario
            Session["Email"] = "";
            Session["Nombre"] = "";
            Session["Cedula"] = "";
            Session["Direccion"] = "";
            Session["Telefono"] = "";
            Session["Password"] = "";

            Session["EmailCliente"] = "";
            Session["Tipo"] = "";
            Session["NombreCliente"] = "";
            Session["Documento"] = "";
            Session["TelefonoCliente"] = "";
            Session["Pais"] = "";
            Session["Linea"] = "";
            Session["Area"] = "";
            Session["CodigoPostal"] = "";
            Session["DireccionCliente"] = "";
            Session["Encuesta"] = "";
            Session["Firma"] = "";
        }
    }
}