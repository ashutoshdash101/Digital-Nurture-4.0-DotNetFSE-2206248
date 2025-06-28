using System.Net;
using System.Net.Mail;

namespace CustomerCommLib
{
    public class MailSender : IMailSender
    {
        public bool SendMail(string toAddress, string message)
        {
            
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.example.com");

            mail.From = new MailAddress("you@example.com");
            mail.To.Add(toAddress);
            mail.Subject = "Test Mail";
            mail.Body = message;

            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("username", "password");
            smtp.EnableSsl = true;

            smtp.Send(mail);

            return true;
        }
    }
}
