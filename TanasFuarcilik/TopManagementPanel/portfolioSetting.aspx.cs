using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TanasFuarcilik.TopManagementPanel
{
    public partial class portfolioSetting : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["mid"] != null)
                {
                    int id;
                    if (int.TryParse(Request.QueryString["mid"], out id))
                    {
                        OurWork o = dm.GetWork(id);
                        if (o != null)
                        {
                            img_picture1.ImageUrl = "../TopManagementPanel/img/portfolio/" + o.Img1;
                            img_picture2.ImageUrl = "../TopManagementPanel/img/portfolio/" + o.Img2;
                            img_picture3.ImageUrl = "../TopManagementPanel/img/portfolio/" + o.Img3;
                            img_picture4.ImageUrl = "../TopManagementPanel/img/portfolio/" + o.Img4;
                            img_picture5.ImageUrl = "../TopManagementPanel/img/portfolio/" + o.Img5;
                            tb_name.Text = o.Name;
                            ddl_categories.SelectedValue = o.Category;
                            ddl_data.SelectedValue = o.Data;
                        }
                        else
                        {
                            // İlgili personel bulunamadı, gerekli işlemleri yapabilirsiniz.
                        }
                    }
                    else
                    {
                        // Geçersiz personel ID'si, gerekli işlemleri yapabilirsiniz.
                    }
                }
                else
                {
                    // Geçersiz veya eksik sorgu parametresi, gerekli işlemleri yapabilirsiniz.
                }
            }
            ddl_categories.DataTextField = "Name";
            ddl_categories.DataValueField = "ID";
            ddl_categories.DataSource = dm.CategoryList();
            ddl_categories.DataBind();

            ddl_data.DataTextField = "Name";
            ddl_data.DataValueField = "ID";
            ddl_data.DataSource = dm.DataList();
            ddl_data.DataBind();

        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {

        }
    }
}