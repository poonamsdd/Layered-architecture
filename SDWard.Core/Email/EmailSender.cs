using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace SDWardWebApi.Helper.Email
{
    public  static class EmailSender
    {
        public static void SendMail(string To, string From, string Code)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(To);
            mail.From = new MailAddress(From);
            mail.Subject = "Verification Code";
            mail.Body = "Welcome to SDWard\n\nYour Verification Code is  " + Code;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new System.Net.NetworkCredential("sdhealthcarepoonam@gmail.com", "health1594%");  
            smtp.Credentials = new System.Net.NetworkCredential("testmailmvc118@gmail.com", "@Shubham9711!");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}