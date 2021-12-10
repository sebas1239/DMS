using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS.Forms
{
    public partial class frmCliente : System.Web.UI.Page
    {
        int[] barras = new int[3];
        string[] nombres = new string [3];
        #region Variables

        AD.clsCliente m_clscliente = new AD.clsCliente();
        #endregion


        protected void Page_Load(object sender, EventArgs e)
        {
            llenarClientes();
        }

        public string llenarArea()
        {


            DataTable datos = new DataTable();
            datos.Columns.Add(new DataColumn("Area", typeof(string)));
            datos.Columns.Add(new DataColumn("Contador", typeof(string)));


            datos.Rows.Add(new object[] { "Empresa", 11 });
            datos.Rows.Add(new object[] { "Exportaciones", 5 });
            datos.Rows.Add(new object[] { "Hogar", 11 });
            datos.Rows.Add(new object[] { "Venta",8  });



            string strArea;
            strArea = "[['Area','Contador'],";
            foreach (DataRow dr in datos.Rows)
            {
                strArea = strArea + "[";
                strArea = strArea + "'" + dr[0] + "'" + "," + dr[1];
                strArea = strArea + "]";
            }











            //m_clscliente.llenarArea();
            //string strArea;
            //strArea = "[['Area','Contador'],";
            //foreach (AD.dstCliente.tbAreaIndicadorRow dr in m_clscliente.tbAreaIndicador.Rows)
            //{
            //    strArea = strArea + "[";
            //    strArea = strArea + "'" + dr.Area + "'" + "," + dr.Contador;
            //    strArea = strArea + "]";
            //}
            return strArea;
        }

        public void llenarClientes()
        {
              m_clscliente.llenarCliente();
            grdCliente.DataSource = m_clscliente.tbCliente;
            grdCliente.DataBind();

        }
}
}