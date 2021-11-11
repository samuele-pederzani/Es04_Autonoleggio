using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Es04_Autonoleggio
{
    public partial class login : System.Web.UI.Page
    {
        clsDB db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new clsDB("App_Data\\autonoleggio.mdf");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt;
                dt = db.cercaUtente(txtInputEmail.Text, 
                    db.sha256(txtInputPassword.Text));
                if (dt.Rows.Count == 0)
                    lblMsg.Text = "Email o password non corretti";
                else
                {
                    Session["idTipo"] = dt.Rows[0].ItemArray[1].ToString();
                    Session["email"] = txtInputEmail.Text;
                    switch (dt.Rows[0].ItemArray[1].ToString())
                    {
                        case "1":
                            Response.Redirect("acquirente.aspx", false);
                            break;
                        case "2":
                            Response.Redirect("dipendente.aspx", false);
                            break;
                        case "3":
                            Response.Redirect("admin.aspx", false);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Session["errore"] = ex.Message;
                Response.Redirect("pagErrore.aspx");
            }
        }

        protected void lnkRegistrati_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrazione.aspx", false);
        }
    }
}