using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Es04_Autonoleggio
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //controllo che chi accede alla pagina
            //sia amministratore
            if (Session["idTipo"] == null || Convert.ToInt32(Session["idTipo"].ToString()) < 3)
                Response.Redirect("login.aspx", false);
        }
    }
}