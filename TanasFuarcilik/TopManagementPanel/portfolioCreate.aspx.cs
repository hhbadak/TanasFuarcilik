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

                for (int i = 1; i <= 5; i++)
                {
                    FileUpload fu_picture = (FileUpload)Page.FindControl("fu_picture" + i); 
                    if (fu_picture.HasFile)
                    {
                        FileInfo fi = new FileInfo(fu_picture.FileName);
                        if (fi.Extension == ".jpg" || fi.Extension == ".png")
                        {
                            string extension = fi.Extension;
                            string name = Guid.NewGuid().ToString();
                            string imageName = name + extension;
                            imageNames.Add(imageName); 
                            fu_picture.SaveAs(Server.MapPath("~/TopManagementPanel/img/personnel/" + imageName));
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
                        imageNames.Add(null); 
                    }
                }

                try
                {
                    // Görüntü isimlerini personele ata
                    o.Img1 = imageNames.Count >= 1 ? imageNames[0] : "none.png";
                    o.Img2 = imageNames.Count >= 2 ? imageNames[1] : null;
                    o.Img3 = imageNames.Count >= 3 ? imageNames[2] : null;
                    o.Img4 = imageNames.Count >= 4 ? imageNames[3] : null;
                    o.Img5 = imageNames.Count >= 5 ? imageNames[4] : null;

                    if (dm.PersonnelCreate(o))
                    {
                        tb_name.Text = "";
                        ddl_categories.SelectedValue = "0";
                        pnl_unsuccessful.Visible = false;
                        pnl_successful.Visible = true;
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
                    lbl_message.Text = ex.Message;
                }
            }
            else
            {
                pnl_unsuccessful.Visible = true;
                pnl_successful.Visible = false;
                lbl_message.Text = "Durum seçimi yapmalısınız.";
            }
        }
    }
}