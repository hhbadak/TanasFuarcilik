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
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["mid"]);

                    Personnel p = dm.GetPersonnel(id);
                    img_picture.ImageUrl = "../TopManagementPanel/img/personnel/" + p.Image;
                    tb_name.Text = p.Name;
                    tb_surname.Text = p.Surname;
                    tb_password.Text = p.Password;
                    tb_mission.Text = p.Mission;
                    tb_phone.Text = p.PhoneNumber;
                    tb_mail.Text = p.EMail;
                    tb_address.Value = p.Address;
                }
            }
            else
            {
                Response.Redirect("../TopManagementPanel/personnel.aspx");
            }
        }

        protected void lbtn_post_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["mid"]);
            Personnel p = dm.GetPersonnel(id);
            p.Name = tb_name.Text;
            p.Surname = tb_surname.Text;
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
                    fu_picture.SaveAs(Server.MapPath("~/../TopManagementPanel/img/personnel" + name + extension));
                }
                else
                {
                }
            }
            if (dm.PersonnelSetting(p))
            {

            }
            else
            {
            }
        }
    }

}