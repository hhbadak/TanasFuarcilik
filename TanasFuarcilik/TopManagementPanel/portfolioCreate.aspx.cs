using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TanasFuarcilik.TopManagementPanel
{
    public partial class portfolioCreate : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_categories.DataTextField = "Name";
                ddl_categories.DataValueField = "ID";
                ddl_categories.DataSource = dm.CategoryList();
                ddl_categories.DataBind();
            }
        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddl_categories.SelectedItem.Value) != 0)
            {
                OurWork o = new OurWork();
                o.Name = tb_name.Text;
                o.CategoryID = Convert.ToInt32(ddl_categories.SelectedItem.Value);

                List<string> imageNames = new List<string>();

                // Resim 1
                if (fu_picture1.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_picture1.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string extension = fi.Extension;
                        string name = Guid.NewGuid().ToString();
                        string imageName = name + extension;
                        imageNames.Add(imageName);
                        fu_picture1.SaveAs(Server.MapPath("~/TopManagementPanel/img/portfolio/" + imageName));
                    }
                    else
                    {
                        pnl_unsuccessful.Visible = true;
                        pnl_successful.Visible = false;
                        lbl_message.Text = "Resim uzantısı sadece .jpg veya .png olmalıdır.";
                        return;
                    }
                }
                else
                {
                    imageNames.Add("none.png");
                }

                // Resim 2
                if (fu_picture2.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_picture2.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string extension = fi.Extension;
                        string name = Guid.NewGuid().ToString();
                        string imageName = name + extension;
                        imageNames.Add(imageName);
                        fu_picture2.SaveAs(Server.MapPath("~/TopManagementPanel/img/portfolio/" + imageName));
                    }
                    else
                    {
                        pnl_unsuccessful.Visible = true;
                        pnl_successful.Visible = false;
                        lbl_message.Text = "Resim uzantısı sadece .jpg veya .png olmalıdır.";
                        return;
                    }
                }
                else
                {
                    imageNames.Add("none.png");
                }

                // Resim 3
                if (fu_picture3.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_picture3.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string extension = fi.Extension;
                        string name = Guid.NewGuid().ToString();
                        string imageName = name + extension;
                        imageNames.Add(imageName);
                        fu_picture3.SaveAs(Server.MapPath("~/TopManagementPanel/img/portfolio/" + imageName));
                    }
                    else
                    {
                        pnl_unsuccessful.Visible = true;
                        pnl_successful.Visible = false;
                        lbl_message.Text = "Resim uzantısı sadece .jpg veya .png olmalıdır.";
                        return;
                    }
                }
                else
                {
                    imageNames.Add("none.png");
                }

                // Resim 4
                if (fu_picture4.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_picture4.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string extension = fi.Extension;
                        string name = Guid.NewGuid().ToString();
                        string imageName = name + extension;
                        imageNames.Add(imageName);
                        fu_picture4.SaveAs(Server.MapPath("~/TopManagementPanel/img/portfolio/" + imageName));
                    }
                    else
                    {
                        pnl_unsuccessful.Visible = true;
                        pnl_successful.Visible = false;
                        lbl_message.Text = "Resim uzantısı sadece .jpg veya .png olmalıdır.";
                        return;
                    }
                }
                else
                {
                    imageNames.Add("none.png");
                }

                // Resim 5
                if (fu_picture5.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_picture5.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string extension = fi.Extension;
                        string name = Guid.NewGuid().ToString();
                        string imageName = name + extension;
                        imageNames.Add(imageName);
                        fu_picture5.SaveAs(Server.MapPath("~/TopManagementPanel/img/portfolio/" + imageName));
                    }
                    else
                    {
                        pnl_unsuccessful.Visible = true;
                        pnl_successful.Visible = false;
                        lbl_message.Text = "Resim uzantısı sadece .jpg veya .png olmalıdır.";
                        return;
                    }
                }
                else
                {
                    imageNames.Add("none.png");
                }
                try
                {
                   
                    if (dm.WorkCreate(o))
                    {
                        tb_name.Text = "";
                        ddl_categories.SelectedValue = "0";
                        pnl_unsuccessful.Visible = false;
                        pnl_successful.Visible = true;
                        lbl_message.Text = "İş oluşturma başarıyla tamamlandı.";
                    }
                    else
                    {
                        throw new Exception("Kayıt oluşturma başarısız oldu.");
                    }
                }
                catch (Exception ex)
                {
                    pnl_unsuccessful.Visible = true;
                    pnl_successful.Visible = false;
                    lbl_message.Text = "Hata oluştu: " + ex.Message;
                    return;
                }
            }
        }
    }
}