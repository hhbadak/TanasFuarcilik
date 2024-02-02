using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TanasFuarcilik.TopManagementPanel
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Personnel p = (Personnel)Session["person"];
            if (Session["person"] != null)
            {
                imgAvatar.ImageUrl = "../TopManagementPanel/img/personnel/" + p.Image;
                lbl_name.Text = p.Name + " " + p.Surname;
                lbl_mission.Text = p.Mission;
            }
            else
            {
                Response.Redirect("../TopManagementPanel/SignIn.aspx");
            }
        }
    }
}