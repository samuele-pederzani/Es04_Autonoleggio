using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Es04_Autonoleggio
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //controllo se sono autenticato
            if(Session["idTipo"]==null)
            {
                lnkLogin.Visible = true;
                lnkLogout.Visible = false;
            }
            else
            {
                lnkLogin.Visible = false;
                lnkLogout.Visible = true;
            }
        }

        protected void lnkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx", false);
        }

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx", false);
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("home.aspx", false);
        }
    }
}