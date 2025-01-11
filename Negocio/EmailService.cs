using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EmailService
    {
        private MailMessage mail;
        private SmtpClient smtpClient;

        public EmailService()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("testeosweband@gmail.com", "yzqz yxoo hfkb vgvw");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
        }
        public void armarCorreo(string destinatario, string asunto, string cuerpo)
        {
            mail = new MailMessage();
            mail.From = new MailAddress("testeosweband@gmail.com");
            mail.To.Add(destinatario);
            mail.Subject = asunto;
            mail.IsBodyHtml = true;
            mail.Body = cuerpo;
        }
        public void enviarCorreo()
        {
            try
            {
                smtpClient.Send(mail);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
