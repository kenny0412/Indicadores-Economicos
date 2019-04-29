using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Indicadores_Economicos.Controllers
{
    public class EmailController : Controller
    {
        //Email controller
        public void sendEmail(String asunto, String body, String correo)
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress(correo));
            email.From = new MailAddress("kennyc680@gmail.com");
            email.Subject = asunto;
            email.Body = body;
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            string output = null;
            SmtpClient smtp = instanciaSmtp();



            try
            {
                smtp.Send(email);

                email.Dispose();
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }

        }

        public SmtpClient instanciaSmtp()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("kennyc680@gmail.com", "kenny04121998");
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            return smtp;
        }
    }
}