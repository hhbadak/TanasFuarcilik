using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TanasFuarcilik.TopManagementPanel
{
    public partial class SignIn : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_login_Click(object sender, EventArgs e)
        {
            Personnel p = dm.PersonnelLogin(tb_username.Text, tb_password.Text);
            if (p != null)
            {
                Session["person"] = p;

                if (Session["link"] == null)
                {
                    Response.Redirect("../TopManagementPanel/index.aspx");
                }
                else
                {
                    Response.Redirect(Session["link"].ToString());
                }
            }
            else
            {
               
            }
        }
    }
}