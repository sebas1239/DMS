using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DMS
{
    public partial class _Default : Page
    {
        #region Variables
        AD.clsUser m_clsUser = new AD.clsUser();
        #endregion

        # region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            m_clsUser.llenarUsuario();
            grdUsuarios.DataSource = m_clsUser.tbUsuario;
            grdUsuarios.DataBind();
            
            



        }
        #endregion

    }
}