using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TanasFuarcilik
{
    public partial class addPersonnel : System.Web.UI.Page
    {
        DataModel dm = new DataModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_statu.DataSource = dm.StatuList();
                ddl_statu.DataBind();
            }
        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {

            string address = tb_address.Value;
            if (int.TryParse(ddl_statu.SelectedItem.Value, out int selectedValue) && selectedValue != 0)
            {
                Personnel p = new Personnel();
                p.Name = tb_name.Text;
                p.Surname = tb_surname.Text;
                p.Password = tb_password.Text;
                p.Mission = tb_mission.Text;
                p.PhoneNumber = tb_phone.Text;
                p.EMail = tb_mail.Text;
                p.Address = tb_address.Value;
                p.StatuID = selectedValue;
                p.Statu = true;
                if (fu_picture.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_picture.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png")
                    {
                        string extension = fi.Extension;
                        string name = Guid.NewGuid().ToString();
                        p.Image = name + extension;
                        fu_picture.SaveAs(Server.MapPath("~/TopManagementPanel/img/personnel/" + name + extension));
                        try
                        {
                            if (dm.PersonnelCreate(p))
                            {
                                tb_name.Text = "";
                                tb_surname.Text = "";
                                tb_password.Text = "";
                                tb_mission.Text = "";
                                tb_phone.Text = "";
                                tb_mail.Text = "";
                                tb_address.Value = "";
                                ddl_statu.SelectedValue = "0";
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
                        lbl_message.Text = "Resim uzantısı sadece .jpg veya .png olmalıdır.";
                    }
                }
                else
                {
                    p.Image = "none.png";
                    try
                    {
                        if (dm.PersonnelCreate(p))
                        {
                            tb_name.Text = "";
                            tb_surname.Text = "";
                            tb_password.Text = "";
                            tb_mission.Text = "";
                            tb_phone.Text = "";
                            tb_mail.Text = "";
                            tb_address.Value = "";
                            ddl_statu.SelectedValue = "0";
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