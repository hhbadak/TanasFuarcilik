using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace TanasFuarcilik.TopManagementPanel
{
    public partial class index : System.Web.UI.MasterPage
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["person"] != null)
            {
                Personnel p = (Personnel)Session["person"];
                lbl_name.Text = p.Name;
                imgAvatar.ImageUrl = "../TopManagementPanel/img/personnel/" + p.Image;
            }
            else
            {
                Response.Redirect("../TopManagementPanel/SignIn.aspx");
            }
        }
    }
}