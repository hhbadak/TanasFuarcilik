using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TanasFuarcilik
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void SendEmail(string senderEmail, string senderName, string subject, string message)
        {
            string email = "your-email@example.com"; // Gönderici e-posta adresi
            string password = "your-password"; // Gönderici e-posta şifresi

            MailMessage mail = new MailMessage();
            SmtpClient smtpClient = new SmtpClient("smtp.example.com"); // SMTP sunucusu bilgilerini buraya girin

            mail.From = new MailAddress(email);
            mail.To.Add(email); // E-postanın gönderileceği adresi buraya girin
            mail.Subject = subject;
            mail.Body = $"Gönderen: {senderName} ({senderEmail})\n\n{message}";

            smtpClient.Port = 587; // SMTP sunucusunun port numarasını buraya girin
            smtpClient.Credentials = new NetworkCredential(email, password);
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mail);
                Console.WriteLine("E-posta başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("E-posta gönderilirken bir hata oluştu: " + ex.Message);
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string senderEmail = "sender@example.com"; // Gönderenin e-posta adresi
            string senderName = "Sender Name"; // Gönderenin adı
            string subject = "Email Subject"; // E-posta konusu
            string message = "Email message"; // E-posta mesajı

            SendEmail(senderEmail, senderName, subject, message);
        }
    }
}