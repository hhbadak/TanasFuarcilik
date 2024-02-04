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
    public partial class personnelSetting : System.Web.UI.Page
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
                        Personnel p = dm.GetPersonnel(id);
                        if (p != null)
                        {
                            img_picture.ImageUrl = "../TopManagementPanel/img/personnel/" + p.Image;
                            tb_name.Text = p.Name;
                            tb_surname.Text = p.Username;
                            tb_password.Text = p.Password;
                            tb_mission.Text = p.Mission;
                            tb_phone.Text = p.PhoneNumber;
                            tb_mail.Text = p.EMail;
                            tb_address.Value = p.Address;
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
        }

        protected void lbtn_post_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["mid"] != null)
            {
                int id;
                if (int.TryParse(Request.QueryString["mid"], out id))
                {
                    Personnel p = dm.GetPersonnel(id);
                    if (p != null)
                    {
                        p.Name = tb_name.Text;
                        p.Username = tb_surname.Text;
                        p.Password = tb_password.Text;
                        p.Mission = tb_mission.Text;
                        p.PhoneNumber = tb_phone.Text;
                        p.EMail = tb_mail.Text;
                        p.Address = tb_address.Value;
                        if (fu_picture.HasFile)
                        {
                            FileInfo fi = new FileInfo(fu_picture.FileName);
                            if (fi.Extension == ".jpg" || fi.Extension == ".png")
                            {
                                string extension = fi.Extension;
                                string name = Guid.NewGuid().ToString();
                                p.Image = name + extension;
                                fu_picture.SaveAs(Server.MapPath("~/../TopManagementPanel/img/personnel/" + name + extension));
                            }
                            else
                            {
                                // Desteklenmeyen dosya uzantısı, gerekli işlemleri yapabilirsiniz.
                            }
                        }
                        if (dm.PersonnelSetting(p))
                        {
                            // Personel ayarları başarıyla güncellendi, gerekli işlemleri yapabilirsiniz.
                        }
                        else
                        {
                            // Personel ayarları güncelleme başarısız, gerekli işlemleri yapabilirsiniz.
                        }
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
    }

}