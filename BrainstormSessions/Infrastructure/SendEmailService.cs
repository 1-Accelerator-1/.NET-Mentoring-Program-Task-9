using BrainstormSessions.Core.Interfaces;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace BrainstormSessions.Infrastructure
{
    public class SendEmailService : ISendEmailService
    {
        public void SendLogFileToEmail(string emailFrom, string passwordFrom, string emailTo, string pathToFile)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(emailFrom, passwordFrom),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            var email = new MailMessage
            {
                From = new MailAddress(emailFrom, "Brain storm session"),
                Subject = "Log File",
                IsBodyHtml = false,
            };

            email.Attachments.Add(new Attachment(pathToFile));
            email.To.Add(emailTo);

            smtpClient.Send(email);
        }
    }
}
