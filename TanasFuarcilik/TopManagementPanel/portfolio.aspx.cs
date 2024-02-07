using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TanasFuarcilik.TopManagementPanel
{
    public partial class portfolio : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }


        }
        private void BindData()
        {
            // Verileri veritabanından al
            List<OurWork> dataList = dm.WorkList();

            // Repeater kontrolüne verileri bağla
            Repeater1.DataSource = dataList;
            Repeater1.DataBind();
        }

    }
}