using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TanasFuarcilik.TopManagementPanel
{
    public partial class personnel : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            data();
        }
        public void data()
        {
            lv_personnelList.DataSource = dm.PersonnelList();
            lv_personnelList.DataBind();
        }

        protected void lv_personnelList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }
    }
}